using CIS_560_Project_Team_16.Models;
using CIS_560_Project_Team_16.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Project_Team_16.Controllers
{
    /// <summary>
    /// A controller for both the log in and create account windows
    /// </summary>
    public class WindowController
    {

        /// <summary>
        /// Delegate to clear the AL tool strip message
        /// </summary>
        ClearALToolStripMessageDEL clearALToolStripMessage;

        /// <summary>
        /// Delegate to update the AL tool strip message
        /// </summary>
        UpdateALToolStripMessageDEL updateALToolStripMessage;

        /// <summary>
        /// Delegate to clear the AC tool stirp message
        /// </summary>
        ClearACToolStripMessageDEL clearACToolStripMessage;

        /// <summary>
        /// Delegate to update the AC tool strip message
        /// </summary>
        UpdateACToolStripMessageDEL updateACToolStripMessage;

        /// <summary>
        /// Delegate to show the AC window
        /// </summary>
        ShowACWindowDEL showACWindow;

        /// <summary>
        /// Delegate to show the AL window
        /// </summary>
        ShowALWindowDEL showALWindow;

        /// <summary>
        /// Delegate to show the Main Window
        /// </summary>
        ShowMainWindowDEL showMainWindow;

        /// <summary>
        /// Information pertaining to a user that is logged in, if there is one
        /// </summary>
        UserModel user;

        //Stores the information needed to establish DB connection
        SqlConnection loginDBconnection = new SqlConnection(@"Data Source=(localDB)\MSSQLLocalDB;Initial Catalog=CIS560Project;Integrated Security=True");

        public WindowController()
        {
            user = new("", new List<MovieModel>(), new List<MovieModel>());
        }

        /// <summary>
        /// Checks both username and password and returns accordingly
        /// </summary>
        /// <param name="username">The username pulled from the username textbox</param>
        /// <param name="user_password">The password pulled from password textbox</param>
        /// <returns>True if login credentials were valid, false otherwise</returns>
        public bool ValidateCredentials_AL(string username, string user_password)
        {
            //Clears AL toolstrip message, if any
            clearALToolStripMessage();

            //Query to pulls the specified username and password combo, if possible
            string loginQuery = "SELECT * FROM MovieDatabase.Account WHERE username = '" + username + "' AND password = '" + user_password + "'";

            //Adapts the information retrieved into a format that can be stored in a few different ways
            //here in C#
            SqlDataAdapter sdaLogin = new SqlDataAdapter(loginQuery, loginDBconnection);

            //Creates a datatable to store the information temporarily
            DataTable dtLogin = new DataTable();
            sdaLogin.Fill(dtLogin);

            if (dtLogin.Rows.Count > 0)
            {
                //-----Temporary message to show the credentials matched-----
                //updateALToolStripMessage("Credentials validated!");
                return true;
            }
            else
            {
                //Updates the AL toolstrip message to show that provided information does not match
                //anything on record
                updateALToolStripMessage("Username or password is incorrect");
                return false;
            }
        }

        /// <summary>
        /// Check if the username textbox contains an existing username in the DB
        /// </summary>
        /// <param name="username">The username we are checking the DB for</param>
        /// <returns>True when a username exists in the DB, false otherwise</returns>
        public bool CheckDBForUsername_AC(string username)
        {
            //Clears AL tool strip message, if any
            clearALToolStripMessage();

            //Query to check only for the given username
            string usernameCheckQuery = "SELECT * FROM MovieDatabase.Account WHERE username = '" + username + "'";

            try
            {
                //Executes query
                SqlDataAdapter sdaUsername = new SqlDataAdapter(usernameCheckQuery, loginDBconnection);

                //Creates and stores the username in a datatable, if it exists. Otherwise, creates
                //empty datatable
                DataTable usernamePull = new DataTable();
                sdaUsername.Fill(usernamePull);

                //Checks if username was stored in datatable and returns accordingly
                if (usernamePull.Rows.Count > 0)
                {
                    updateACToolStripMessage("Username already exists! Try logging in instead.");
                    return true;
                }
                else
                {
                    clearACToolStripMessage();
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
        /// Compares the passwords given by user in AC window
        /// </summary>
        /// <param name="proposedPassword">The first textbox's contents</param>
        /// <param name="confirmationPassword">The second textbox's contents</param>
        /// <returns>True if passwords match, false otherwise</returns>
        public bool ComparePasswords_AC(string username, string proposedPassword, string confirmationPassword)
        {
            
            if (proposedPassword == "" || confirmationPassword == "")
            {
                updateACToolStripMessage("Password cannot be blank. Try again.");
                return false;
            }
            else if(proposedPassword != confirmationPassword)
            {
                updateACToolStripMessage("Passwords do not match. Try again.");
                return false;
            }
            else
            {
                //Temporary message, will store account info to DB then transfer to Login Page
                updateACToolStripMessage("Passwords match! Account created!");
                StoreNewCredentials(username, proposedPassword);
                return true;
            }
        }

        /// <summary>
        /// Takes the given username and password and stores them in the DB
        /// </summary>
        /// <param name="username">The new username</param>
        /// <param name="password">The new password</param>
        private void StoreNewCredentials(string username, string password)
        {
            string query = "INSERT INTO MovieDatabase.Account VALUES ('"+username+"','"+password+"')";

            loginDBconnection.Open();
            SqlCommand cmd = new SqlCommand(query, loginDBconnection);
            cmd.ExecuteNonQuery();
            loginDBconnection.Close();
        }

        /// <summary>
        /// Registers the delegate towards the AccountLogin window to clear its toolstrip message
        /// </summary>
        /// <param name="del">The method from the AccountLogin window that clears the toolstrip message</param>
        public void RegisterClearALMessageDel(ClearALToolStripMessageDEL del)
        {
            clearALToolStripMessage = del;
        }

        /// <summary>
        /// Registers the delegate towards the AccountLogin window to update its toolstrip message
        /// </summary>
        /// <param name="del">The method from the AccountLogin window that updates the toolstrip message</param>
        public void RegisterUpdateALMessageDel(UpdateALToolStripMessageDEL del)
        {
            updateALToolStripMessage = del;
        }

        /// <summary>
        /// Registers the delegate towards the AccountCreation window to clear its toolstrip message
        /// </summary>
        /// <param name="del">The method from the AccountCreation window that clears the toolstrip message</param>
        public void RegisterClearACMessageDel(ClearACToolStripMessageDEL del)
        {
            clearACToolStripMessage = del;
        }

        /// <summary>
        /// Registers the delegate towards the AccountCreation window to update its toolstrip message
        /// </summary>
        /// <param name="del">The method from the AccountCreation window that updates the toolstrip message</param>
        public void RegisterUpdateACMessageDel(UpdateACToolStripMessageDEL del)
        {
            updateACToolStripMessage = del;
        }

        /// <summary>
        /// Registers the delegate towards the AccountCreation window to show the window itself
        /// </summary>
        /// <param name="del">Method that shows the AccountCreation window</param>
        public void RegisterShowACWindowDel(ShowACWindowDEL del)
        {
            showACWindow = del;
        }

        /// <summary>
        /// Registers the delegate towards the AccountLogin window to show the window itself
        /// </summary>
        /// <param name="del">Method that shows the AccountLogin window</param>
        public void RegisterShowALWindowDel(ShowALWindowDEL del)
        {
            showALWindow = del;
        }

        /// <summary>
        /// Registers the delegate towards the MainWindow to show the window itself
        /// </summary>
        /// <param name="del">Method that shows the MainWindow</param>
        public void RegisterShowMainWindowDel(ShowMainWindowDEL del)
        {
            showMainWindow = del;
        }

        /// <summary>
        /// A reference method for AL window to show AC window
        /// </summary>
        public void ShowACWindowController()
        {
            showACWindow();
        }

        /// <summary>
        /// A reference method for AC window to show AL window
        /// </summary>
        public void ShowALWindowController()
        {
            showALWindow();
        }

        /// <summary>
        /// A reference method for the AL window to show the MainWindow upon succesful login
        /// </summary>
        public void ShowMainWindowController()
        {
            showMainWindow();
        }
    }
}
