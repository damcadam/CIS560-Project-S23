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
        //Stores the information needed to establish DB connection
        SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=CIS560Project;Integrated Security=True");

        //Adds reference to the account creation screen, if necessary
        private AccountCreation _accountCreationScreen;

        public AccountLogin()
        {
            InitializeComponent();
            _accountCreationScreen = new AccountCreation(this);
        }

        /// <summary>
        /// Updates the Toolstrip message at the bottom of the login window with the message parameter
        /// </summary>
        /// <param name="message">The message to update the Toolstrip text to</param>
        private void UpdateToolStripMessage(string message)
        {
            uxALToolStripLabel.Text = message;
        }

        /// <summary>
        /// Clears the message in the Toolstrip at the bottom of the login window
        /// </summary>
        private void ClearToolStripMessage()
        {
            uxALToolStripLabel.Text = "";
        }


        /// <summary>
        /// Checks both username and password and returns accordingly
        /// </summary>
        /// <param name="username">The username pulled from the username textbox</param>
        /// <param name="user_password">The password pulled from password textbox</param>
        /// <returns>True if login credentials were valid, false otherwise</returns>
        private bool ValidateCredentials(string username, string user_password)
        {
            ClearToolStripMessage();

            //Query to pulls the specified username and password combo, if possible
            string loginQuery = "SELECT * FROM LoginCredentials WHERE username = '" + username + "' AND password = '" + user_password + "'";

            SqlDataAdapter sdaLogin = new SqlDataAdapter(loginQuery, connection);

            DataTable dtLogin = new DataTable();
            sdaLogin.Fill(dtLogin);

            if (dtLogin.Rows.Count > 0)
            {
                //uxALToolStripLabel.Text = "Credentials Validated";
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if the username textbox contains an existing username in the DB
        /// </summary>
        /// <param name="username">The username we are checking the DB for</param>
        /// <returns>True when a username exists in the DB, false otherwise</returns>
        private bool CheckDBForUsername(string username)
        {
            ClearToolStripMessage();

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
        /// Check if there is a user for that username and password in the database.
        /// If so populate the UserSelection with the correct info for from the account
        /// and show the UserSelection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSignIn_Click(object sender, EventArgs e)
        {
            string username = uxALUsernameTextBox.Text, password = uxALPasswordTextBox.Text;

            //Checks for an account with the provided username and compares passwords
            if (ValidateCredentials(username, password))
            {
                //Clears textboxes
                uxALUsernameTextBox.Text = "";
                uxALPasswordTextBox.Text = "";

                ShowMainWindow();
            }
            // Username is not in database
            else
            {
                uxALToolStripLabel.Text = "Username or password is not correct.";
            }
        }

        /// <summary>
        /// Opens the Account Creation window and hides the Login window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateAccount_Click(object sender, EventArgs e)
        {
            _accountCreationScreen.Show();
            this.Hide();
        }

        /// <summary>
        /// Shows the main window while also hiding all others, if needed
        /// </summary>
        private void ShowMainWindow()
        {
            
        }

        private void AccountLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
