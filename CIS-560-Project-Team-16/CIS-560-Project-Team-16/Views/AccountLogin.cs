using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CIS_560_Project_Team_16.Views;

namespace CIS_560_Project_Team_16
{
    /// <summary>
    /// GUI for logging a person into their account. An account may have multiple users
    /// </summary>
    public partial class AccountLogin : Form
    {
        private AccountCreation accountCreationScreen;

        public AccountLogin()
        {
            InitializeComponent();
            accountCreationScreen = new AccountCreation(this);
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=CIS560Project;Integrated Security=True");

        /// <summary>
        /// Check if there is a user for that username and password in the database.
        /// If so populate the UserSelection with the correct info for from the account
        /// and show the UserSelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSignIn_Click(object sender, EventArgs e)
        {
            string username = uxALUsernameTextBox.Text, password = uxALPasswordTextBox.Text;

            //Checks for an account with the provided username
            if (CheckDBForUsername(username))
            {

                //Show MainWindow with information loaded based on account
                ShowMainWindow();
            }
            // Username is not in database
            else
            {
                uxALToolStripLabel.Text = "Username or password is not correct.";
            }
        }

        /// <summary>
        /// Check if the username textbox contains an existing username in the DB
        /// </summary>
        /// <param name="username">The username we are checking the DB for</param>
        /// <returns>True when a username exists in the DB, false otherwise</returns>
        private bool CheckDBForUsername(string username)
        {
            //Clears notification
            uxALToolStripLabel.Text = "";

            //Query to check only for the given username
            string usernameCheckQuery = "SELECT * FROM LoginCredentials WHERE username = '" + username + "'";

            try
            {
                //Executes query
                SqlDataAdapter sdaUsername = new SqlDataAdapter(usernameCheckQuery, connection);

                //Creates and stores the username in a datatable, if it exists. Otherwise, creates
                //empty datatable
                DataTable usernamePull = new DataTable();
                sdaUsername.Fill(usernamePull);

                //Checks if username was stored in datatable and returns accordingly
                if (usernamePull.Rows.Count > 0)
                {
                    //uxALToolStripLabel.Text = "Username found!";
                    return true;
                }
                else
                {
                    //uxALToolStripLabel.Text = "Username NOT found!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                //In the event there was an issue pulling information from DB
                MessageBox.Show("Error establishing connection to database. See details: \n" + ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Create a new account for the user if this username and password
        /// does not exist in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateAccount_Click(object sender, EventArgs e)
        {
            accountCreationScreen.Show();
            this.Hide();
        }

        private void ShowMainWindow()
        {

        }

        /// <summary>
        /// Create a new account with this username and password
        /// </summary>
        private void CreateAccount()
        {

        }

        private void AccountLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
