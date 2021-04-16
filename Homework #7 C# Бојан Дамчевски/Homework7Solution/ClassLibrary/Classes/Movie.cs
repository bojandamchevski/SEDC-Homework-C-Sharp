using System;
using System.Text;
using ClassLibrary.Enums;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, double rating)
        {
            if (rating < 1 || rating > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("Rating must be between 1 and 5");
            }
            if (string.IsNullOrEmpty(title))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("You must enter a title");
            }

            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;
        }
    }
}
