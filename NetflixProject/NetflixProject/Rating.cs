using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{   public enum Ratings
    {
        One = 1,
        Two,
        Three,
        Four,
        Five
    }
    class Rating
    {
        public void MakeRatingList()
        {
            List<Ratings> ratingList = new List<Ratings>();

            foreach (int rate in Enum.GetValues(typeof(Ratings)))
            {
                Console.WriteLine(rate);
            }
            

        }
    }
}
