using System;
using ClassLibrary.Classes;
using ClassLibrary.Enums;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
                Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
                Movie movie3 = new Movie("Saw", Genre.Horror, 4);
                Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
                Movie movie5 = new Movie("Rambo", Genre.Action, 4);
                Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
                Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
                Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
                Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
                Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);
                Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
                Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
                Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
                Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
                Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
                Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
                Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
                Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
                Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
                Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);
                List<Movie> MovieSet1 = new List<Movie>() {
                    movie1,
                    movie2,
                    movie3,
                    movie4,
                    movie5,
                    movie6,
                    movie7,
                    movie8,
                    movie9,
                    movie10
                };
                List<Movie> MovieSet2 = new List<Movie>() {
                    movie11,
                    movie12,
                    movie13,
                    movie14,
                    movie15,
                    movie16,
                    movie17,
                    movie18,
                    movie19,
                    movie20
                };
                Cinema cinema1 = new Cinema("Cineplexx", new List<int>() { 1, 2, 3, 4 }, MovieSet1);
                Cinema cinema2 = new Cinema("Milenium", new List<int>() { 1, 2 }, MovieSet2);
                Cinema currentCinema = null;
                Console.WriteLine("Choose cinema");
                Console.WriteLine($"1) {cinema1.Name}");
                Console.WriteLine($"2) {cinema2.Name}");
                string input = Console.ReadLine();
                int cinema = int.Parse(input);
                if (cinema == 1)
                {
                    currentCinema = cinema1;
                }
                else if (cinema == 2)
                {
                    currentCinema = cinema2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("You must choose valid cinema");
                }


                Console.WriteLine("Choose option");
                Console.WriteLine($"1) all movies");
                Console.WriteLine($"2) movies by genre");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Choose movie");
                    foreach (Movie movie in currentCinema.ListOfMovies)
                    {
                        Console.WriteLine(movie.Title);
                    }
                    string chosenMovie = Console.ReadLine();
                    currentCinema.WatchMovie(currentCinema.ListOfMovies
                        .FirstOrDefault(x => x.Title.ToLower() == chosenMovie.ToLower()));
                }
                else if (option == 2)
                {
                    int counter = 1;
                    Console.WriteLine("Please type your desired genre: Comedy, Horror, Action, Drama and SciFi.");
                    string genreChoice = Console.ReadLine();
                    if (Enum.TryParse(genreChoice, out Genre genres))
                    {
                        List<Movie> byGenre = currentCinema.ListOfMovies.Where(movie => movie.Genre.ToString().Equals(genreChoice, StringComparison.InvariantCultureIgnoreCase)).ToList();
                        Console.WriteLine("Movies by your desired genre: ");
                        foreach (Movie movie in byGenre)
                        {
                            Console.WriteLine("{0}) {1}", counter, movie.Title);
                            counter++;
                        }
                        Console.WriteLine("Please enter the movie you want to watch: ");
                        string movieChoice = Console.ReadLine();
                        if (String.IsNullOrEmpty(movieChoice))
                        {
                            throw new Exception("Enter a movie name !");
                        }
                        else
                        {
                            currentCinema.WatchMovie(byGenre.FirstOrDefault(movie => movie.Title.ToString().Equals(movieChoice, StringComparison.InvariantCultureIgnoreCase)));
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        throw new Exception("Enter a valid movie genre!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("You must choose valid option");
                }
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine("Incorrect input");
            }
            catch (NullReferenceException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.WriteLine("Movie does not exist");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
