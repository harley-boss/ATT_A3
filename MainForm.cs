// File:        MainForm.cs
// Assignment:  Assignment 3 - MongoDB
// Programmer:  Harley Boss
// Class:       ATT
// Date:        March 29th 2020
// Description: Main form that handles all the logic for interacting with the database and presenting
//              the results to the user



using A3_MongoDB_hboss.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A3_MongoDB_hboss {


    public partial class MainForm : Form {
        private IMongoDatabase database;
        private MongoClient mongoClient;
        private MenuItem currentMenuItem;
        private List<Person> people = new List<Person>();
        private List<Movie> movies = new List<Movie>();
        private IMongoCollection<FullMovie> fullMovieCollection;


        /// <summary>
        /// Enum to represent what the user wants to search
        /// </summary>
        private enum MenuItem {
            ACTOR,
            MOVIE,
            OVERVIEW
        }




        /// <summary>
        /// Constructor for the form
        /// </summary>
        /// <param name="mongoClient"></param>
        /// <param name="database"></param>
        public MainForm(MongoClient mongoClient, IMongoDatabase database) {
            InitializeComponent();
            this.CenterToScreen();
            this.mongoClient = mongoClient;
            this.database = database;
            rbMoviesForActor.Checked = true;
            ObtainDatabaseData();
            CreateIndexes();
            PopulateActorsComboBox();
            PopulateMoviesComboBox();
            DetermineMenuItem();
        }




        /// <summary>
        /// Creates the indexes for the various fields that are being searched
        /// </summary>
        private void CreateIndexes() {
            if (fullMovieCollection != null) {
                fullMovieCollection.Indexes.CreateOne(Builders<FullMovie>.IndexKeys.Ascending(_ => _.cast));
                fullMovieCollection.Indexes.CreateOne(Builders<FullMovie>.IndexKeys.Ascending(_ => _.overview));
                fullMovieCollection.Indexes.CreateOne(Builders<FullMovie>.IndexKeys.Ascending(_ => _._Id));
            } 
        }




        /// <summary>
        /// Gets the data from the database for the people and movies collections
        /// </summary>
        private void ObtainDatabaseData() {
            var peopleCollection = database.GetCollection<BsonDocument>("people");
            var moviesCollection = database.GetCollection<BsonDocument>("movies");
            var filter = Builders<BsonDocument>.Filter.Empty;
            var peoplesResult = peopleCollection.Find(filter).ToList();
            var moviesResult = moviesCollection.Find(filter).ToList();
           
            foreach (var person in peoplesResult) {
                people.Add(new Person(person));
            }
      
            foreach (var movie in moviesResult) {
                movies.Add(new Movie(movie));
            }

            List<FullMovie> fullMovies = Helpers.CreateFullMovieList(people, movies);            
            CreateFullMoviesCollection(fullMovies);
        }




        /// <summary>
        /// Populates a combobox with all the movies in the collection
        /// </summary>
        private void PopulateMoviesComboBox() {
            if (movies.Count > 0) {
                foreach (Movie movie in movies) {
                    cmbMoviesList.Items.Add(movie.id);
                }
            }
        }




        /// <summary>
        /// Populates a combobox with all the actors in the collection
        /// </summary>
        private void PopulateActorsComboBox() {
            if (people.Count > 0) {
                foreach (Person person in people) {
                    cmbActorsList.Items.Add(person.id);
                }
            }
        }




        /// <summary>
        /// Creates a collection with the new fullmovie objects
        /// </summary>
        /// <param name="fullMovies"></param>
        private void CreateFullMoviesCollection(List<FullMovie> fullMovies) {
            database.DropCollection("fullmovies");
            database.CreateCollection("fullmovies");
            fullMovieCollection = database.GetCollection<FullMovie>("fullmovies");
            fullMovieCollection.InsertMany(fullMovies);
        }





        /// <summary>
        /// Determines which radio button is checked
        /// </summary>
        private void DetermineMenuItem() {
            if (rbOverview.Checked) {
                currentMenuItem = MenuItem.OVERVIEW;
            } else if (rbMoviesForActor.Checked) {
                currentMenuItem = MenuItem.MOVIE;
            } else {
                currentMenuItem = MenuItem.ACTOR;
            }
            HandleMenuItems(currentMenuItem);
        }




        /// <summary>
        /// Updates the UI based on which radio button is selected
        /// </summary>
        /// <param name="item"></param>
        private void HandleMenuItems(MenuItem item) {
            ClearUi();
            switch (item) {
                case MenuItem.OVERVIEW:
                    cmbActorsList.Enabled = false;
                    cmbMoviesList.Enabled = false;
                    tbKeyword.Enabled = true;
                    btnSearch.Enabled = true;
                    break;
                case MenuItem.ACTOR:
                    cmbActorsList.Enabled = false;
                    cmbMoviesList.Enabled = true;
                    tbKeyword.Enabled = false;
                    btnSearch.Enabled = false;
                    break;
                case MenuItem.MOVIE:
                    cmbActorsList.Enabled = true;
                    cmbMoviesList.Enabled = false;
                    tbKeyword.Enabled = false;
                    btnSearch.Enabled = false;
                    break;
            }
        }




        /// <summary>
        /// Handles getting the currently selected actor from the combo box and querying the collection
        /// for all movies that actor appeared in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActorsListChanged(object sender, EventArgs e) {
            if (cmbActorsList.SelectedIndex != -1) {
                lBoxResults.Items.Clear();
                String currentActor = cmbActorsList.SelectedItem.ToString();
                var results = fullMovieCollection.Find(x => x.cast.Contains(currentActor)).ToList();
                foreach (FullMovie f in results) {
                    lBoxResults.Items.Add(f._Id);
                }
            }
        }




        /// <summary>
        /// Handles querying the database based on the currently selected database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoviesListChanged(object sender, EventArgs e) {
            if (cmbMoviesList.SelectedIndex != -1) {
                lBoxResults.Items.Clear();
                String currentMovie = cmbMoviesList.SelectedItem.ToString();
                var results = fullMovieCollection.Find(x => x._Id.Contains(currentMovie)).ToList();
                foreach (FullMovie f in results) {
                    foreach (String castMember in f.cast)
                        lBoxResults.Items.Add(castMember);
                }
            }
        }




        /// <summary>
        /// Event handler for when actor radio button is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbActorChanged(object sender, EventArgs e) {
            DetermineMenuItem();
        }




        /// <summary>
        /// Event handler for when movie radio button is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMovieChanged(object sender, EventArgs e) {
            DetermineMenuItem();
        }




        /// <summary>
        /// Event handler for when overview radio button is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbOverviewChanged(object sender, EventArgs e) {
            DetermineMenuItem();
        }




        /// <summary>
        /// Event handler for when the user hits search button to search by overview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e) {
            String overview = tbKeyword.Text;
            lBoxResults.Items.Clear();
            var results = fullMovieCollection.Find(x => x.overview.Contains(overview)).ToList();
            foreach (FullMovie f in results) {
                lBoxResults.Items.Add(f._Id);
                lBoxResults.Items.Add(f.overview);
                lBoxResults.Items.Add(Environment.NewLine);
                lBoxResults.Items.Add(Environment.NewLine);
            }
        }




        /// <summary>
        /// Resets the UI elements on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e) {
            ClearUi();
            DetermineMenuItem();
        }




        /// <summary>
        /// Clears all UI items
        /// </summary>
        private void ClearUi() {
            lBoxResults.Items.Clear();
            tbKeyword.Text = "";
            cmbActorsList.SelectedIndex = -1;
            cmbMoviesList.SelectedIndex = -1;
        }
    }
}
