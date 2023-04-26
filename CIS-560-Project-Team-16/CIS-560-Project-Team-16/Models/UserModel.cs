using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Project_Team_16.Models
{
    public class UserModel
    {
        /// <summary>
        /// The username that the user has associated with them
        /// </summary>
        private string _username;

        /// <summary>
        /// A public access point for the users stored username
        /// </summary>
        public string Username => _username;

        /// <summary>
        /// The users stored favorites, if any
        /// </summary>
        private DataTable _favorites;

        /// <summary>
        /// A public access point for the users stored favorite movies
        /// </summary>
        public DataTable Favorites => _favorites;

        /// <summary>
        /// The users region
        /// </summary>
        private string _region;

        /// <summary>
        /// A public access point for the users stored region
        /// </summary>
        public string Region => _region;

        public UserModel(string usernameIn, DataTable favoritesIn, string regionIn)
        {
            _username = usernameIn;
            _favorites = favoritesIn;
            _region = regionIn;
        }
    }
}
