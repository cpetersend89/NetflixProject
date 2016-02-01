using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public class TvShow : Title
    {
        public TvShow()
        {
        }
        List<Title> allepisodes = new List<Title>();
        public void MakeTvShowList()
        {
            allepisodes.Add(new Title() { name = "Episode 1: Human Flesh", rating = 3.5 });
            allepisodes.Add(new Title() { name = "Episode 2: Crawl Space", rating = 7.6 });
            allepisodes.Add(new Title() { name = "Episode 3: Sacred Cow", rating = 7.6 });
            allepisodes.Add(new Title() { name = "Episode 4: Sexy Dance Fighting", rating = 7.0 });
            allepisodes.Add(new Title() { name = "Episode 5: Hamburger Dinner Theater", rating = 7.8 });
            allepisodes.Add(new Title() { name = "Episode 6: Sheesh! Cab, Bob?", rating = 8.1 });
            allepisodes.Add(new Title() { name = "Episode 7: Bed & Breakfast", rating = 7.5 });
            allepisodes.Add(new Title() { name = "Episode 8: Art Crawl", rating = 6.7 });
            allepisodes.Add(new Title() { name = "Episode 9: Spaghetti Western & Meatballs", rating = 6.8 });
            allepisodes.Add(new Title() { name = "Episode 10: Burger Wars", rating = 8.2 });
            allepisodes.Add(new Title() { name = "Episode 11: Weekend at Mort's", rating = 6.6 });
            allepisodes.Add(new Title() { name = "Episode 12: Lobsterfest", rating = 7.8 });
            allepisodes.Add(new Title() { name = "Episode 13: Torpedo", rating = 6.8 });

            foreach (Title tv in allepisodes)
            {
                Console.WriteLine(tv);
            }
        }
        public void CreateTitle()
        {
            Console.WriteLine("\nTV Show: Bob's Burgers\n");
        }

    }
}
