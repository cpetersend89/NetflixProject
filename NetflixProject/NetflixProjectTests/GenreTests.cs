using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject.Tests
{
    [TestClass()]
    public class GenreTests
    {

        [TestMethod()]
        public void MakeAllMovieListTest()
        {
            List<Movie> allmovies = new List<Movie>();
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

        [TestMethod()]
        public void FindActionMoviesTest()
        {
        }

        [TestMethod()]
        public void FindComedyMoviesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindRomanceMoviesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindRomanticComediesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetEnumeratorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void JustMovieNamesTest()
        {
            Assert.Fail();
        }
    }
}