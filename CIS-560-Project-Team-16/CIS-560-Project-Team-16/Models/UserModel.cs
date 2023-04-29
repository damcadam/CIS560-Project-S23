using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Project_Team_16.Models
{
    /// <summary>
    /// A users information
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// The ID associated with this account
        /// </summary>
        public int AccountID { get; set; }

        /// <summary>
        /// A public access point for the users stored username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// A public access point for the users watchlistID in string format
        /// </summary>
        public int WatchListID { get; set; }

        /// <summary>
        /// The UserModel constructor, instantiates the users username, favorites, and watchlist
        /// </summary>
        /// <param name="usernameIn">The users associated username</param>
        /// <param name="accountIDin">The accounts ID</param>
        /// <param name="watchlistIDin">The watchlistID associated with the user</param>
        public UserModel(int accountIDin, string usernameIn, int watchlistIDin) 
        {
            AccountID = accountIDin;
            Username = usernameIn;
            WatchListID = watchlistIDin;
        }
    }
}
