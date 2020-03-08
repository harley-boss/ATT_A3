using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace A3_MongoDB_hboss {
    public partial class MainForm : Form {
        private IMongoDatabase database;
        private MongoClient mongoClient;
        private MenuItem currentMenuItem;
        private List<String> actors = new List<string>();

        private enum MenuItem {
            KEYWORD,
            MULTIPLE,
            SINGLE
        }

        public MainForm(MongoClient mongoClient, IMongoDatabase database) {
            InitializeComponent();
            this.CenterToScreen();
            this.mongoClient = mongoClient;
            this.database = database;
            PopulateActorsList();
            rbMultiple.Checked = true;
            DetermineMenuItem();
        }

        private void PopulateActorsList() {
            var peopleCollection = database.GetCollection<BsonDocument>("people");
            var moviesCollection = database.GetCollection<BsonDocument>("movies");
            var filter = Builders<BsonDocument>.Filter.Empty;
            var peoplesResult = peopleCollection.Find(filter).ToList();
            var moviesResult = moviesCollection.Find(filter).ToList();

            CreateFullMoviesCollection();

            // Create a list of actors that can be used to populate the combo box
            foreach (var person in peoplesResult) {
                actors.Add(person.GetValue("_id").AsString);
            }
            cmbActorsList.Items.AddRange(actors.ToArray());
        }

        private void CreateFullMoviesCollection() {
            // TODO check for existance of full movies collection and only create if
            // it doesn't exist
            database.CreateCollection("fullmovies");
        }

        private void DetermineMenuItem() {
            if (rbKeyword.Checked) {
                currentMenuItem = MenuItem.KEYWORD;
            } else if (rbMultiple.Checked) {
                currentMenuItem = MenuItem.MULTIPLE;
            } else {
                currentMenuItem = MenuItem.SINGLE;
            }
            HandleMenuItems(currentMenuItem);
        }

        private void HandleMenuItems(MenuItem item) {
            ClearUi();
            switch (item) {
                case MenuItem.KEYWORD:
                    cmbActorsList.Enabled = false;
                    tbKeyword.Enabled = true;
                    lBoxActors.Enabled = false;
                    lBoxActors.BackColor = Color.LightGray;
                    break;
                case MenuItem.SINGLE:
                    cmbActorsList.Enabled = true;
                    tbKeyword.Enabled = false;
                    lBoxActors.Enabled = false;
                    lBoxActors.BackColor = Color.LightGray;
                    break;
                case MenuItem.MULTIPLE:
                    cmbActorsList.Enabled = true;
                    tbKeyword.Enabled = false;
                    lBoxActors.Enabled = true;
                    lBoxActors.BackColor = Color.White;
                    break;
            }
        }

        private void ActorsListChanged(object sender, EventArgs e) {
            if (cmbActorsList.SelectedIndex != -1) {
                String currentActor = cmbActorsList.SelectedItem.ToString();
                if (currentMenuItem == MenuItem.SINGLE) {
                    cmbActorsList.Enabled = false;
                }
                lBoxActors.Items.Add(currentActor);
            }
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e) {
            DetermineMenuItem();
        }

        private void rbKeyword_CheckedChanged(object sender, EventArgs e) {
            DetermineMenuItem();
        }

        private void rbMultiple_CheckedChanged(object sender, EventArgs e) {
            DetermineMenuItem();
        }

        private void btnSearch_Click(object sender, EventArgs e) {

        }

        private void btnReset_Click(object sender, EventArgs e) {
            rbMultiple.Checked = true;
            ClearUi();
            DetermineMenuItem();
        }

        private void ClearUi() {
            lBoxActors.Items.Clear();
            lBoxResults.Items.Clear();
            tbKeyword.Text = "";
            cmbActorsList.SelectedIndex = -1;
        }
    }
}
