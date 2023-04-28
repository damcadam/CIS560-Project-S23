using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        /// A public access point for the users stored username
        /// </summary>
        public string Username { get; set; } 

        /// <summary>
        /// A public access point for the users stored favorite movies in List<> format
        /// </summary>
        public List<MovieModel> Favorites { get; set; }

        /// <summary>
        /// A public access point for the users anticipated movies in List<> format
        /// </summary>
        public List<MovieModel> WatchList { get; set; }

        /// <summary>
        /// The UserModel constructor, instantiates the users username, favorites, and watchlist
        /// </summary>
        /// <param name="usernameIn">The users associated username</param>
        /// <param name="favoritesIn">The users existing favorites list</param>
        /// <param name="watchlistIn">The users existing watchlist</param>
        public UserModel(string usernameIn, List<MovieModel> favoritesIn, List<MovieModel> watchlistIn) 
        { 
            Username = usernameIn;
            Favorites = favoritesIn;
            WatchList = watchlistIn;
        }
    }
}
