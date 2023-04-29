using CIS_560_Project_Team_16.Controllers;
using CIS_560_Project_Team_16.Views;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;
using System.IO;
using CIS_560_Project_Team_16.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CIS_560_Project_Team_16
{
    public delegate void ClearALToolStripMessageDEL();
    public delegate void UpdateALToolStripMessageDEL(string message);
    public delegate void ClearACToolStripMessageDEL();
    public delegate void UpdateACToolStripMessageDEL(string message);
    public delegate bool ValidateALCredentialsDEL(string username, string user_password);
    public delegate bool CheckACDBForUsernameDEL(string username);
    public delegate bool CompareACPasswordsDEL(string username, string password1, string password2);
    public delegate void ShowACWindowDEL();
    public delegate void NotifyControllerShowACWindowDEL();
    public delegate void ShowALWindowDEL();
    public delegate void NotifyControllerShowALWindowDEL();
    public delegate void ShowMainWindowDEL();
    public delegate void NotifyControllerShowMainWindowDEL();

    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Creates controller
            WindowController controller = new();

            // Create the different forms
            AccountLogin logInWindow = new(controller.ValidateCredentials_AL,
                controller.ShowACWindowController,
                controller.ShowMainWindowController);
            AccountCreation accCreateWindow = new(controller.CheckDBForUsername_AC,
                controller.ComparePasswords_AC,
                controller.ShowALWindowController);
            MainWindow mainWindow = new();

            //Register all communicative methods between views and controller
            controller.RegisterClearALMessageDel(logInWindow.ClearALToolStripMessage);
            controller.RegisterUpdateALMessageDel(logInWindow.UpdateToolStripMessage);
            controller.RegisterClearACMessageDel(accCreateWindow.ClearACToolStripMessage);
            controller.RegisterUpdateACMessageDel(accCreateWindow.UpdateACToolStripMessage);
            controller.RegisterShowACWindowDel(accCreateWindow.ShowACWindow);
            controller.RegisterShowALWindowDel(logInWindow.ShowALWindow);
            controller.RegisterShowMainWindowDel(mainWindow.ShowMainWindow);

            BulkCopyData();

            // Run the application
            Application.Run(logInWindow);
        }

        /// <summary>
        /// Method for bulk copying movie data from the IMDb TSVs. This needs to get called after
        /// the tables are rebuilt
        /// </summary>
        private static void BulkCopyData()
        {
            string command = "bcp";
            string rootFolder = GetProjectRoot();

            // Build and run BCP command for all the tables
            string arguments = "CIS560Project.MovieDatabase.Directors in \"" + rootFolder + "\\Sql\\Data\\MovieOutput.tsv\" -S \"(localdb)\\MSSQLLocalDb\" -T -f \"" + rootFolder + "\\Sql\\Data\\DirectorFormat.fmt\" -h \"CHECK_CONSTRAINTS\"";
            RunCMDCommand(command, arguments);
        }

        /// <summary>
        /// Helper method to run a command line command with some args
        /// </summary>
        /// <param name="command"></param>
        /// <param name="args"></param>
        private static void RunCMDCommand(string command, string args)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = command;
            proc.StartInfo.Arguments = args;
            proc.Start();
            proc.WaitForExit();
        }

        /// <summary>
        /// Gets the root folder of the project. Used so the bcp
        /// command function works for any user.
        /// </summary>
        /// <returns>root project folder</returns>
        /// <exception cref="InvalidOperationException"></exception>
        static string GetProjectRoot()
        {
            // Get the assembly location (where the compiled code resides)
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;

            // Get the full path of the assembly (including its name)
            string assemblyPath = Path.GetDirectoryName(assemblyLocation);

            // Move up from the 'bin' folder to the project root folder
            DirectoryInfo directoryInfo = new DirectoryInfo(assemblyPath);
            while (directoryInfo.Name != null && !string.Equals(directoryInfo.Name, "bin", StringComparison.OrdinalIgnoreCase))
            {
                directoryInfo = directoryInfo.Parent;
            }

            // If the 'bin' folder is not found, it means that the project root could not be determined
            if (directoryInfo.Name == null)
            {
                throw new InvalidOperationException("Project root folder could not be determined.");
            }

            // Return the parent folder of 'bin' as the project root folder
            return directoryInfo.Parent.FullName;
        }

        /// <summary>
        /// This method
        /// 1. Creates the schema if it doesn't exist
        /// 2. Drops all tables
        /// 3. Creates all tables. However, the order they get called in will need to change
        ///     based on FK relations
        ///     
        /// I tested the method and the scripts do run and the database changes stay. 
        /// NOTE: For the entire script to run right we'll need to change order tables get created
        /// and all the scripts that create the tables with FKs need to work
        /// </summary>
        private static void RebuildDatabase()
        {
            // Create a connection to the database
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=CIS560Project;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // NOTE: for the path the work, the sql files must have the 
            // copy out property set to Copy Always

            // Build correct paths to all the SQL files needed to rebuild the database
            string currentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string schemaPath = Path.Combine(currentDirectory, "Sql", "Schemas", "Schema.sql");
            string dropTablesPath = Path.Combine(currentDirectory, "Sql", "Tables", "_DropTables.sql");
            string accountPath = Path.Combine(currentDirectory, "Sql", "Tables", "Account.sql");
            string actorPath = Path.Combine(currentDirectory, "Sql", "Tables", "Actor.sql");
            string directorsPath = Path.Combine(currentDirectory, "Sql", "Tables", "Directors.sql");
            string genrePath = Path.Combine(currentDirectory, "Sql", "Tables", "Genre.sql");
            string genreValuesPath = Path.Combine(currentDirectory, "Sql", "Tables", "genreValues.sql");
            string languagePath = Path.Combine(currentDirectory, "Sql", "Tables", "Language.sql");
            string movieCastPath = Path.Combine(currentDirectory, "Sql", "Tables", "movieCast.sql");
            string moviesPath = Path.Combine(currentDirectory, "Sql", "Tables", "movies.sql");
            string reviewsPath = Path.Combine(currentDirectory, "Sql", "Tables", "Reviews.sql");
            string watchListPath = Path.Combine(currentDirectory, "Sql", "Tables", "WatchList.sql");

            // First run the SQL fire to create the schema if it doesn't exist
            string schemaScript = File.ReadAllText(schemaPath);
            SqlCommand schemaCommand = new SqlCommand(schemaScript, connection);
            schemaCommand.ExecuteNonQuery();

            //// Then drop all of the tables
            string dropScript = File.ReadAllText(dropTablesPath);
            SqlCommand dropCommand = new SqlCommand(dropScript, connection);
            dropCommand.ExecuteNonQuery();

            // Create all the tables
            // Account
            string accountScript = File.ReadAllText(accountPath);
            SqlCommand accountCommand = new SqlCommand(accountScript, connection);
            accountCommand.ExecuteNonQuery();
            // Actor
            string actorScript = File.ReadAllText(actorPath);
            SqlCommand actorCommand = new SqlCommand(actorScript, connection);
            actorCommand.ExecuteNonQuery();
            // Directors
            string directorsScript = File.ReadAllText(directorsPath);
            SqlCommand directorsCommand = new SqlCommand(directorsScript, connection);
            directorsCommand.ExecuteNonQuery();
            // Genre
            string genreScript = File.ReadAllText(genrePath);
            SqlCommand genreCommand = new SqlCommand(genreScript, connection);
            genreCommand.ExecuteNonQuery();
            // Genre Values
            string genreValuesScript = File.ReadAllText(genreValuesPath);
            SqlCommand genreValuesCommand = new SqlCommand(genreValuesScript, connection);
            genreValuesCommand.ExecuteNonQuery();
            // Language
            string languageScript = File.ReadAllText(languagePath);
            SqlCommand languageCommand = new SqlCommand(languageScript, connection);
            languageCommand.ExecuteNonQuery();
            // Movie Cast
            string movieCastScript = File.ReadAllText(movieCastPath);
            SqlCommand movieCastCommand = new SqlCommand(movieCastScript, connection);
            movieCastCommand.ExecuteNonQuery();
            // Movies
            string moviesScript = File.ReadAllText(moviesPath);
            SqlCommand moviesCommand = new SqlCommand(moviesScript, connection);
            moviesCommand.ExecuteNonQuery();
            // Reviews
            string reviewsScript = File.ReadAllText(reviewsPath);
            SqlCommand reviewsCommand = new SqlCommand(reviewsScript, connection);
            reviewsCommand.ExecuteNonQuery();
            // WatchList
            string watchListScript = File.ReadAllText(watchListPath);
            SqlCommand watchListCommand = new SqlCommand(watchListScript, connection);
            watchListCommand.ExecuteNonQuery();

            // Close the connection
            connection.Close();
        }
    }
}