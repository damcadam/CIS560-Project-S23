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
        /// A public access point for the users stored username
        /// </summary>
        public string Username { get; set; } 

        /// <summary>
        /// A public access point for the users stored favorite movies
        /// </summary>
        public DataTable Favorites { get; set; }

        /// <summary>
        /// A public access point for the users stored region
        /// </summary>
        public string Region { get; set; }

        public UserModel(string usernameIn, DataTable favoritesIn, string regionIn) 
        { 
            Username = usernameIn;
            Favorites = favoritesIn;
            Region = regionIn;
        }
    }
}
