using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Movie : Title
    {
        public Genres category1 { get; set; }
        public Genres category2 { get; set; }
        public int duration { get; set; }
        public Movie()
        {

        }
        public override string ToString()
        {
            return name + ": " + duration + " minutes " + rating + "/10 stars ";
        }
    }
}
