using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Movie : IEquatable<Movie>
    {
        public string name { get; set; }
        public Genres category1 { get; set; }
        public Genres category2 { get; set; }
        public int rating { get; set; }
        public int duration { get; set; }

        public override string ToString()
        {
            return name + ": " + duration + " minutes " + rating + "/10 stars ";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Movie objAsTitle = obj as Movie;
            if (objAsTitle == null) return false;
            else return Equals(objAsTitle);
        }
        public override int GetHashCode()
        {
            return rating;
        }
        public bool Equals(Movie other)
        {
            if (other == null) return false;
            return (this.rating.Equals(other.rating));
        }
    }
}