using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 3");

            string input = Console.ReadLine();
            int number;
            bool numberSuccess = int.TryParse(input, out number);

            switch (number)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Error, wrong input!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
