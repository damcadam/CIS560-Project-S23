using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

using System.Data;
using System.Data.SqlClient;
using CIS_560_Project_Team_16.Models;

namespace CIS_560_Project_Team_16
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create the different forms
            AccountLogin accountLogin = new();
            MainWindow mainWindow = new();
            UserSelection userSelection = new();

            // Give GUIs objects to the others so they can show and hide each other
            accountLogin.SetUserWindow(userSelection);

            TestSql test = new();
            string output = test.test();


            // Run the application
            Application.Run(new AccountLogin());
        }

    }
}