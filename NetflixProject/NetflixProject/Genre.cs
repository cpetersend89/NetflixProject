using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    public enum Genres { Action, Comedy, Romance }
    public class Genre : IEnumerable
    {
        public Genre()
        {
        }
        List<Movie> allmovies = new List<Movie>();

        public void MakeAllMovieList()
        {
            allmovies.Add(new Movie() { category1 = Genres.Action, name = "Gladiator", duration = 153, rating = 8.5 });
            allmovies.Add(new Movie() { category1 = Genres.Action, name = "Batman", duration = 126, rating = 7.6 });
            allmovies.Add(new Movie() { category1 = Genres.Action, name = "The Hunger Games: Catching Fire", duration = 146, rating = 7.6 });
            allmovies.Add(new Movie() { category1 = Genres.Action, name = "Crank", duration = 88, rating = 7.0 });
            allmovies.Add(new Movie() { category1 = Genres.Action, name = "Star Trek Into Darkness", duration = 132, rating = 7.8 });
            allmovies.Add(new Movie() { category1 = Genres.Action, name = "Kill Bill: Volume 1", duration = 111, rating = 8.1 });
            allmovies.Add(new Movie() { category1 = Genres.Action, name = "Equilibrium", duration = 107, rating = 7.5 });
            allmovies.Add(new Movie() { category1 = Genres.Comedy, name = "The Interview", duration = 112, rating = 6.7 });
            allmovies.Add(new Movie() { category1 = Genres.Comedy, name = "Bernie", duration = 87, rating = 6.8 });
            allmovies.Add(new Movie() { category1 = Genres.Comedy, name = "Trainspotting", duration = 84, rating = 8.2 });
            allmovies.Add(new Movie() { category1 = Genres.Comedy, name = "Zoolander", duration = 89, rating = 6.6 });
            allmovies.Add(new Movie() { category1 = Genres.Comedy, category2 = Genres.Romance, name = "Silver Linings Playbook", duration = 122, rating = 7.8 });
            allmovies.Add(new Movie() { category1 = Genres.Comedy, category2 = Genres.Romance, name = "Adventureland", duration = 107, rating = 6.8 });
            allmovies.Add(new Movie() { category1 = Genres.Comedy, category2 = Genres.Romance, name = "Don Jon", duration = 90, rating = 6.6 });
            allmovies.Add(new Movie() { category1 = Genres.Romance, name = "Punch-Drunk Love", duration = 95, rating = 7.3 });
            allmovies.Add(new Movie() { category1 = Genres.Romance, name = "Like Crazy", duration = 90, rating = 6.7 });
            allmovies.Add(new Movie() { category1 = Genres.Romance, name = "Blue Valentine", duration = 112, rating = 7.4 });
            allmovies.Add(new Movie() { category1 = Genres.Romance, name = "Beautiful Girls", duration = 112, rating = 7.2 });
            allmovies.Add(new Movie() { category1 = Genres.Romance, name = "Weekend", duration = 97, rating = 7.7 });
            allmovies.Add(new Movie() { category1 = Genres.Romance, name = "Blue is the Warmest Color", duration = 179, rating = 7.8 });
            allmovies.Add(new Movie() { category1 = Genres.Romance, name = "As Good as It Gets", duration = 139, rating = 7.7 });

            foreach (Movie m in allmovies)
            {
                Console.WriteLine(m);
            }
        }

        /*public static Genre operator +(Genre c1, Genre c2)
        {

            return new Genre(c1.FindActionMovies() + c2.FindComedyMovies());
        }*/

        public void FindActionMovies()
        {
            List<Movie> actionmovies = new List<Movie>();
            actionmovies = allmovies.FindAll(x => x.category1 == Genres.Action);
            foreach (Movie a in actionmovies)
            {
                Console.WriteLine(a);
            }
        }
        public void FindComedyMovies()
        {
            List<Movie> comedymovies = new List<Movie>();
            comedymovies = allmovies.FindAll(x => x.category1 == Genres.Comedy);
            foreach (Movie c in comedymovies)
            {
                Console.WriteLine(c);
            }
        }
        public void FindRomanceMovies()
        {
            List<Movie> romanticmovies = new List<Movie>();
            romanticmovies = allmovies.FindAll(x => x.category1 == Genres.Romance);
            foreach (Movie r in romanticmovies)
            {
                Console.WriteLine(r);
            }
        }
        public void FindRomanticComedies()
        {
            List<Movie> romanticcomedies = new List<Movie>();
            romanticcomedies = allmovies.FindAll(x => x.category1 == Genres.Comedy && x.category2 == Genres.Romance);
            foreach (Movie rc in romanticcomedies)
            {
                Console.WriteLine(rc);
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < allmovies.Count; i++)
            {
                yield return allmovies[i];
            }
        }
        public void JustMovieNames()
        {
            foreach (Movie moviename in allmovies)
            {
                Console.WriteLine(moviename.name);
            }
        }
    }
}
