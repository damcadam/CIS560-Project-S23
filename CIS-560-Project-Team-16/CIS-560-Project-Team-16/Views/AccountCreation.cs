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

        public AccountCreation(CheckACDBForUsernameDEL usernameCheckDeligate,
            CompareACPasswordsDEL comparePasswordsDeligate)
        {
            InitializeComponent();
            checkDBForUsername = usernameCheckDeligate;
            comparePasswords = comparePasswordsDeligate;
        }

        /// <summary>
        /// Attempts user log in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxToLogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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

            if (checkDBForUsername(username))
            {
                if(comparePasswords(password1, password2))
                {
                    //Store new credentials in DB
                }
                else
                {
                    ClearPasswords();
                }
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
    }
}
