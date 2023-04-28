using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_560_Project_Team_16.Models
{
    public class MovieModel
    {
        /// <summary>
        /// Unique int identifier for every movie
        /// </summary>
        public int MovieID { get; set; }

        /// <summary>
        /// Unique int identifier for the movie's director
        /// </summary>
        public int DirectorID { get; set; }

        /// <summary>
        /// The name for the movie
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// The length of the movie in HH:MM
        /// </summary>
        public string Length { get; set; } = "Xhrs Xmin";

        /// <summary>
        /// The release date of the movie in YYYY/MM/DD
        /// </summary>
        public string ReleaseDate { get; set; } = "1999/01/01";

        /// <summary>
        /// List of all the ActorsIDs associated with the movie
        /// </summary>
        public List<int> ActorIDs { get; set; }

        /// <summary>
        /// List of all the LanguageIDs associated with the movie
        /// </summary>
        public List<int> LanguageIDs { get; set; }
    }
}
