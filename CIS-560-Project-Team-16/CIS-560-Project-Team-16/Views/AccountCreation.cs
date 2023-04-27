using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CIS_560_Project_Team_16.Views
{
    public partial class AccountCreation : Form
    {
        /// <summary>
        /// Deligate towards controller that checks the DB for username, returns bool accordingly
        /// </summary>
        CheckACDBForUsernameDEL checkDBForUsername;

        /// <summary>
        /// Deligate towards controller that compares the users given passwords for a match, returns bool accordingly
        /// </summary>
        CompareACPasswordsDEL comparePasswords;

        /// <summary>
        /// Deligate towards controller that notifies it to show the AccountLogin window
        /// </summary>
        NotifyControllerShowALWindowDEL showALWindow;

        public AccountCreation(CheckACDBForUsernameDEL usernameCheckDeligate,
            CompareACPasswordsDEL comparePasswordsDeligate,
            NotifyControllerShowALWindowDEL showALWindowDeligate)
        {
            InitializeComponent();
            uxACPasswordTextBox.UseSystemPasswordChar = true;
            uxACPasswordConfirmTextBox.UseSystemPasswordChar = true;
            checkDBForUsername = usernameCheckDeligate;
            comparePasswords = comparePasswordsDeligate;
            showALWindow = showALWindowDeligate;
        }

        /// <summary>
        /// Attempts user log in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxToLogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearPasswords();
            ClearACToolStripMessage();
            uxACUsernameTextBox.Text = "";
            uxACShowPasswordsCheckBox.Checked = false;
            showALWindow();
        }

        /// <summary>
        /// Closes program upon window close to avoid softlock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountCreation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Attempts to register new user credentials
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSignUpButton_Click(object sender, EventArgs e)
        {
            string username = uxACUsernameTextBox.Text;
            string password1 = uxACPasswordTextBox.Text;
            string password2 = uxACPasswordConfirmTextBox.Text;

            if(username == "")
            {
                UpdateACToolStripMessage("Username cannot be empty! Try again.");
            }
            else if (checkDBForUsername(username))
            {
                //Do nothing, controller handles this message
            }
            else
            {
                if (comparePasswords(password1, password2))
                {
                    //Store new credentials in DB, for now, updates message showing successful comparison
                    uxACUsernameTextBox.Text = "";
                }
                ClearPasswords();
            }
        }

        /// <summary>
        /// Updates the message shown to user in AC window
        /// </summary>
        /// <param name="message">The message to be shown to user</param>
        public void UpdateACToolStripMessage(string message)
        {
            uxACToolStripLabel.Text = message;
        }

        /// <summary>
        /// Clears the AC windows message
        /// </summary>
        public void ClearACToolStripMessage()
        {
            uxACToolStripLabel.Text = "";
        }

        /// <summary>
        /// Clears the passwords in both textboxes to allow user to try again
        /// </summary>
        private void ClearPasswords()
        {
            uxACPasswordTextBox.Text = "";
            uxACPasswordConfirmTextBox.Text = "";
        }

        /// <summary>
        /// Shows the AC window
        /// </summary>
        public void ShowACWindow()
        {
            this.Show();
        }

        private void uxACShowPasswordsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(uxACShowPasswordsCheckBox.Checked)
            {
                uxACPasswordTextBox.UseSystemPasswordChar = false;
                uxACPasswordConfirmTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                uxACPasswordTextBox.UseSystemPasswordChar = true;
                uxACPasswordConfirmTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
