﻿using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter a number.");

            bool success = int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine($"The sum of the digits of the number is: {SumOfDigits(num)}");
            
            Console.WriteLine("Enter another number.");

            string input = Console.ReadLine();

            Console.WriteLine($"The sum of the digits of the number is: {sumOfDigits2(input)}");
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
        static int sumOfDigits2(string number)
        {
            char[] arrayOfTheDigits = number.ToCharArray();

            int sum = 0;

            foreach (char digit in arrayOfTheDigits)
            {
                bool success = int.TryParse(digit.ToString(), out int num);
                sum += num;    
            }

            return sum;
        }
    }
}
