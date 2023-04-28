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
        /// <summary>
        /// Deligate towards the controller that validates the user provided login credentials
        /// </summary>
        ValidateALCredentialsDEL validateCredentials;

        /// <summary>
        /// Deligate towards the controller that has it tell the Account Creation window to Show
        /// </summary>
        NotifyControllerShowACWindowDEL showACWindow;

        /// <summary>
        /// Deligate towards the controller that tells it to show the MainWindow
        /// </summary>
        NotifyControllerShowMainWindowDEL showMainWindow;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validateCredentialsDeligate"></param>
        /// <param name="showACWindowDeligate"></param>
        /// <param name="showMainWindowDeligate"></param>
        public AccountLogin(ValidateALCredentialsDEL validateCredentialsDeligate,
            NotifyControllerShowACWindowDEL showACWindowDeligate,
            NotifyControllerShowMainWindowDEL showMainWindowDeligate)
        {
            InitializeComponent();
            uxALPasswordTextBox.UseSystemPasswordChar = true;
            validateCredentials = validateCredentialsDeligate;
            showACWindow = showACWindowDeligate;
            showMainWindow = showMainWindowDeligate;
        }

        /// <summary>
        /// Updates the Toolstrip message at the bottom of the login window with the message parameter
        /// </summary>
        /// <param name="message">The message to update the Toolstrip text to</param>
        public void UpdateToolStripMessage(string message)
        {
            uxALToolStripLabel.Text = message;
        }

        /// <summary>
        /// Clears the message in the Toolstrip at the bottom of the login window
        /// </summary>
        public void ClearALToolStripMessage()
        {
            uxALToolStripLabel.Text = "";
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
            if (validateCredentials(username, password))
            {
                //Clears textboxes
                uxALUsernameTextBox.Text = "";
                uxALPasswordTextBox.Text = "";

                //Hides this window and shows MainWindow
                this.Hide();
                showMainWindow();
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
        private void uxToCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearALToolStripMessage();
            uxALPasswordTextBox.Text = "";
            uxALUsernameTextBox.Text = "";
            uxALShowPasswordCheckBox.Checked = false;
            showACWindow();
        }

        /// <summary>
        /// Shows the AccountLogin window
        /// </summary>
        public void ShowALWindow()
        {
            this.Show();
        }

        /// <summary>
        /// Closes entire application when window is closed to avoid softlock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Shows or hides the password a user has typed in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uxALShowPasswordCheckBox.Checked)
            {
                uxALPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                uxALPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
