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
        /// <summary>
        /// Object for the UserSelection GUI
        /// </summary>
        private MainWindow _userWindow = new();

        public AccountLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets an object to point at the UserSelection GUI. We need
        /// the reference to show UserSelection once a valid account is logged in
        /// </summary>
        /// <param name="userWindow">UserSelection object created in Program.cs</param>
        public void SetUserWindow(MainWindow userWindow)
        {
            _userWindow = userWindow;
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
            if(CheckDBForAccount(false))
            {
                // Show UserSelection and hide AccountLogin
                PopulateUserSelection();
            }
            // Username/password combo is not in database
            else
            {
                uxToolStripLabel.Text = "Username or password is not correct";
            }
        }

        /// <summary>
        /// Check if the textboxes containsa valid username and password
        /// </summary>
        /// <param name="justCheckUserName">True if we are just checking if a username exists
        /// false if we are checking for both the username and password</param>
        /// <returns>true for valid accounts, false otherwise</returns>
        private bool CheckDBForAccount(bool justCheckUserName)
        {
            // Search database for this account
            // Return true if it's in there
            // False if it's not
            return true;
        }

        /// <summary>
        /// Populate the UserSelection with info from this account
        /// Then Show UserSelection
        /// </summary>
        private void PopulateUserSelection()
        {
            this.Hide();
            _userWindow.Show();
        }

        /// <summary>
        /// Create a new account for the user if this username and password
        /// does not exist in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateAccount_Click(object sender, EventArgs e)
        {
            // Already in there
            if(CheckDBForAccount(true))
            {
                uxToolStripLabel.Text = "There's already an account with that username";
            }
            // Brand new account
            else
            {
                CreateAccount();
                PopulateUserSelection();
            }
        }

        /// <summary>
        /// Create a new account with this username and password
        /// </summary>
        private void CreateAccount()
        {

        }
    }
}
