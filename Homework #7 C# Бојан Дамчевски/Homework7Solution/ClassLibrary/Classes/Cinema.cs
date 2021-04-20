using System;
using System.Text;
using ClassLibrary.Enums;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary.Classes
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("Cinema name must be entered");
            }
            if (halls == null || halls.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("There must be halls");
            }
            if (movies == null || movies.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("There must be movies");
            }
            Name = name;
            Halls = halls;
            ListOfMovies = movies;
        }

        public void WatchMovie(Movie movie)
        {
            if (movie == null)
            {
                throw new Exception("Enter valid movie name!");
            }
            else
            {
                Console.WriteLine($"Watching {movie.Title}");
            }

        }
    }
}
