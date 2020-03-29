// File:        A3_Form.cs
// Assignment:  Assignment 3 - MongoDB
// Programmer:  Harley Boss
// Class:       ATT
// Date:        March 29th 2020
// Description: Handles the login logic and connection to the database



using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace A3_MongoDB_hboss {
    public partial class A3_Form : Form {
        private String connString = 
            "mongodb://{0}:{1}@cluster0-shard-00-00-ea4wg.gcp.mongodb.net:27017,cluster0-" + 
            "shard-00-01-ea4wg.gcp.mongodb.net:27017,cluster0-shard-00-02-ea4wg.gcp.mongodb.net:27017/test?ssl=true" + 
            "&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true&w=majority";

        /// <summary>
        /// Initializes the form
        /// </summary>
        public A3_Form() {
            InitializeComponent();
            this.CenterToScreen();
            btnSignIn.Enabled = false;
        }




        /// <summary>
        /// Handles the button click for sign-in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignIn_Click(object sender, EventArgs e) {
            String userName = tbUserName.Text;
            String password = tbPassword.Text;

            SignIntoMongo(userName, password);
        }




        /// <summary>
        /// Handles the text changed event for the username field, enables the sign-in button
        /// as long as there is some text in the username and password fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbUserName_TextChanged(object sender, EventArgs e) {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0) {
                btnSignIn.Enabled = true;
            } else {
                btnSignIn.Enabled = false;
            }
        }




        /// <summary>
        /// Handles the text changed event for the username field, enables the sign-in button
        /// as long as there is some text in the username and password fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPassword_TextChanged(object sender, EventArgs e) {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0) {
                btnSignIn.Enabled = true;
            } else {
                btnSignIn.Enabled = false;
            }
        }




        /// <summary>
        /// Handles Signing into the MongoDB and tests the connection before proceeding
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        private void SignIntoMongo(String userName, String password) {
            connString = String.Format(connString, userName, password);
            lblError.Text = String.Empty;
            MongoClient client = null;
            IMongoDatabase database = null;
            bool error = false;
            try {
                client = new MongoClient(connString);
                database = client.GetDatabase("ATT-A03");
                var collection = database.GetCollection<BsonDocument>("movies");
                var filter = Builders<BsonDocument>.Filter.Empty;
                collection.Find(filter).ToList();
            } catch (Exception ex) {
                error = true;
                lblError.Text = ex.Message;
                Console.WriteLine(ex.Message);
            }
            if (!error) {
                HideSignIn();
                ShowMainForm(client, database);
            }
        }




        /// <summary>
        /// Hides this form
        /// </summary>
        private void HideSignIn() {
            this.Hide();
        }




        /// <summary>
        /// Shows the main form where user can select from cast data
        /// </summary>
        /// <param name="client">Mongo client</param>
        /// <param name="database">Database being interacted with</param>
        private void ShowMainForm(MongoClient client, IMongoDatabase database) {
            MainForm mainForm = new MainForm(client, database);
            mainForm.Show();
        }




        /// <summary>
        /// Handles an enter click when for signing in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignInKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnSignIn_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            } 
        }
    }
}
