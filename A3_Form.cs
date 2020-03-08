using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace A3_MongoDB_hboss {
    public partial class A3_Form : Form {
        private String connString = "mongodb://{0}:{1}@cluster0-shard-00-00-ea4wg.gcp.mongodb.net:27017,cluster0-shard-00-01-ea4wg.gcp.mongodb.net:27017,cluster0-shard-00-02-ea4wg.gcp.mongodb.net:27017/test?ssl=true&replicaSet=Cluster0-shard-0&authSource=admin&retryWrites=true&w=majority";

        public A3_Form() {
            InitializeComponent();
            this.CenterToScreen();
            btnSignIn.Enabled = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e) {
            String userName = tbUserName.Text;
            String password = tbPassword.Text;

            SignIntoMongo(userName, password);
        }

        private void tbUserName_TextChanged(object sender, EventArgs e) {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0) {
                btnSignIn.Enabled = true;
            } else {
                btnSignIn.Enabled = false;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e) {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0) {
                btnSignIn.Enabled = true;
            } else {
                btnSignIn.Enabled = false;
            }
        }

        private void SignIntoMongo(String userName, String password) {
            connString = String.Format(connString, userName, password);
            try {
                var client = new MongoClient(connString);
                var database = client.GetDatabase("ATT-A03");
                HideSignIn();
                ShowMainForm(client, database);
            } catch (Exception ex) {
                lblError.Text = ex.Message;
                Console.WriteLine(ex.Message);
            }
        }

        private void HideSignIn() {
            this.Hide();
        }

        private void ShowMainForm(MongoClient client, IMongoDatabase database) {
            MainForm mainForm = new MainForm(client, database);
            mainForm.Show();
        }

        private void btnSignInKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnSignIn_Click(sender, e);
                e.SuppressKeyPress = true;
                e.Handled = true;
            } 
        }
    }
}
