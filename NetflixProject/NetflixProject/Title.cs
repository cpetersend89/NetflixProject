using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class Title : IEquatable<Title>
    {
        public string name;
        public double rating;
        public override string ToString()
        {
            return name + ": " + rating + "/10 stars ";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Title objAsTitle = obj as Title;
            if (objAsTitle == null) return false;
            else return Equals(objAsTitle);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Title other)
        {
            if (other == null) return false;
            return (this.rating.Equals(other.rating));
        }
    }
}