using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Films
    {
        public string FilmName;
        private string rating;

        public Films(string aFilmName, string aRating)
        {
            FilmName = aFilmName;
            Rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "There isn't this type of rating.";
                }
            }
        }
    }
}
