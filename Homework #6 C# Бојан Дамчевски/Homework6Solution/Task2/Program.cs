using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void SquareOfTheNumbersInTheList(List<double> collection)
        {
            Console.WriteLine("The numbers in the second list are: ");
            List<double> squareOfNumbers = collection.Select(num => num * num).ToList();
            foreach(double number in squareOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
        static void Main(string[] args)
        {
            List<double> listOfTenNumbers = new List<double>() { 1, 2.5, 3.4, 4, 5, 6.67, 7, 8.12, 9, 10 };
            Console.WriteLine("The numbers in the first list are:");
            foreach (double num in listOfTenNumbers)
            {
                Console.WriteLine(num);
            }
            SquareOfTheNumbersInTheList(listOfTenNumbers);

            Console.ReadLine();
        }
    }
}
