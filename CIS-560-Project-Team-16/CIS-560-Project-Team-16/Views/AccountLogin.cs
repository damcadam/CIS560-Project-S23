using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_560_Project_Team_16
{
    /// <summary>
    /// GUI for logging a person into their account. An account may have multiple users
    /// </summary>
    public partial class AccountLogin : Form
    {
        public AccountLogin()
        {
            InitializeComponent();
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
            string username = uxALUsernameTextBox.Text;
            //Checks for an account with the provided username
            if (CheckDBForAccount(username))
            {

                //Show MainWindow with information loaded based on account
                ShowMainWindow();
            }
            // Usernameis not in database
            else
            {
                uxALToolStripLabel.Text = "Username or password is not correct.";
            }
        }

        /// <summary>
        /// Check if the textboxes containsa valid username and password
        /// </summary>
        /// <param name="username">True if we are just checking if a username exists
        /// false if we are checking for both the username and password</param>
        /// <returns>true for valid accounts, false otherwise</returns>
        private bool CheckDBForAccount(string username)
        {
            // Search database for this account
            // Return true if it's in there
            // False if it's not
            return false;
        }

        /// <summary>
        /// Create a new account for the user if this username and password
        /// does not exist in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateAccount_Click(object sender, EventArgs e)
        {
            string username = uxALUsernameTextBox.Text;
            // Already in there
            if (CheckDBForAccount(username))
            {
                uxALToolStripLabel.Text = "There's already an account with that username";
            }
            // Brand new account
            else
            {
                CreateAccount();
            }
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
    }
}
