using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Genre movies = new Genre();
            Console.WriteLine("All Movies:\n");
            movies.MakeAllMovieList();
            Console.WriteLine("\nAction Movies:\n");
            movies.FindActionMovies();
            Console.WriteLine("\nComedy Movies:\n");
            movies.FindComedyMovies();
            Console.WriteLine("\nRomance Movies:\n");
            movies.FindRomanceMovies();
            Console.WriteLine("\nRomantic Comedies\n");
            movies.FindRomanticComedies();
            Console.WriteLine("\nCustom iterator returning only movie title:\n");
            movies.JustMovieNames();

            TvShow episodes = new TvShow();
            episodes.CreateTitle();
            episodes.MakeTvShowList();


            Console.ReadLine();
        }
    }
}
