﻿using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5");


            Console.WriteLine("Enter your date of birth (day-month-year).");

            string inputBirthDate = Console.ReadLine();

            bool success = DateTime.TryParse(inputBirthDate, out DateTime convertedBirthDate);

            if (!success)
            {
                throw new Exception("Invalid date!");
            }
            else
            {
                Console.WriteLine($"You are {AgeCalculator(convertedBirthDate)} years old.");
            }


            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
        static int AgeCalculator(DateTime birthday)
        {
            DateTime currentDateAndTime = DateTime.Now;
            int currentTimeSpentOnThisPlanet = currentDateAndTime.Year - birthday.Year;

            int age = 0;
            if (currentDateAndTime.Month > birthday.Month)
            {
                age = currentTimeSpentOnThisPlanet - 1;
            }
            else if (currentDateAndTime.Month <= birthday.Month)
            {
                if (currentDateAndTime.Day < birthday.Day)
                {
                    age = currentTimeSpentOnThisPlanet;
                }
                else if (currentDateAndTime.Day == birthday.Day)
                {
                    age = currentTimeSpentOnThisPlanet;
                }
                else if (currentDateAndTime.Day > birthday.Day)
                {
                    age = currentTimeSpentOnThisPlanet - 1;
                }
            }
            return age;
        }
    }
}
