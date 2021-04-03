using System;

namespace Task_1___SumOfEven_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfEven");
            Console.WriteLine("You have to enter 6 numbers!");

            int counter = 0;
            int[] arrayOf6Integers = new int[6];
            while (counter < 6)
            {
                Console.WriteLine("Enter a number: ");
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (!success)
                {
                    throw new Exception("Error, bad input, try again !");
                }
                else
                {
                arrayOf6Integers[counter] = number;
                }
                counter++;
            }

   
            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;

            Console.WriteLine("Here are the numbers you entered!");

            for (int i = 0; i < arrayOf6Integers.Length; i++)
            {
                if (arrayOf6Integers[i] == arrayOf6Integers[arrayOf6Integers.Length - 1])
                {
                    Console.Write(arrayOf6Integers[i] + ".\n");
                }
                else
                {
                    Console.Write(arrayOf6Integers[i] + ", ");
                }
                if (arrayOf6Integers[i] % 2 == 0)
                {
                    sumOfEvenNumbers += arrayOf6Integers[i];
                }
                if (arrayOf6Integers[i] % 2 != 0)
                {
                    sumOfOddNumbers += arrayOf6Integers[i];
                }
            }

            Console.WriteLine("And now the results from the task:");

            Console.WriteLine($"The sum of even numbers is equal to: {sumOfEvenNumbers}");
            Console.WriteLine($"The sum of odd numbers is equal to: {sumOfOddNumbers}");

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
