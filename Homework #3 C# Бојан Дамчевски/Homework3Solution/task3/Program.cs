using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter a number.");

                bool success = int.TryParse(Console.ReadLine(), out int num);

                if (!success)
                {
                    Console.Clear();
                    Console.WriteLine("Bad input please try again !");
                }
                else
                {
                    Console.WriteLine($"The sum of the digits of the number is: {SumOfDigits(num)}");
                    Console.WriteLine("Enter another number.");
                    string input = Console.ReadLine();
                    Console.WriteLine($"The sum of the digits of the number is: {sumOfDigits2(input)}");
                    flag = false;
                    Console.WriteLine("Press any key to exit.");
                }


            }
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
                if (!success)
                {
                    Console.WriteLine("Error, bad input please try again !");
                }
                else
                {
                    sum += num;
                }

            }
            return sum;
        }
    }
}
