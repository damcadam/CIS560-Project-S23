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
        private AccountLogin accountLoginScreen;
        public AccountCreation(AccountLogin loginScreen)
        {
            InitializeComponent();
            accountLoginScreen = loginScreen;
        }

        private void AccountCreation_Load(object sender, EventArgs e)
        {

        }

        private void uxToLogInButton_Click(object sender, EventArgs e)
        {
            accountLoginScreen.Show();
            this.Hide();
        }

        private void AccountCreation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
