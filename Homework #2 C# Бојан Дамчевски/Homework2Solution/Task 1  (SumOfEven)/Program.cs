using System;

namespace Task_1___SumOfEven_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfEven");
            Console.WriteLine("You have to enter 6 numbers!");

            Console.WriteLine("Enter first number!");
            string input1 = Console.ReadLine();
            bool successNum1 = int.TryParse(input1, out int num1);

            Console.WriteLine("Enter second number!");
            string input2 = Console.ReadLine();
            bool successNum2 = int.TryParse(input2, out int num2);

            Console.WriteLine("Enter third number!");
            string input3 = Console.ReadLine();
            bool successNum3 = int.TryParse(input3, out int num3);

            Console.WriteLine("Enter fourth number!");
            string input4 = Console.ReadLine();
            bool successNum4 = int.TryParse(input4, out int num4);

            Console.WriteLine("Enter fifth number!");
            string input5 = Console.ReadLine();
            bool successNum5 = int.TryParse(input5, out int num5);

            Console.WriteLine("Enter sixth number!");
            string input6 = Console.ReadLine();
            bool successNum6 = int.TryParse(input6, out int num6);

            int[] arrayOf6Integers = { num1, num2, num3, num4, num5, num6 };

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
            }

            Console.WriteLine("And now the results from the task:");

            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;

            for (int j = 0; j < arrayOf6Integers.Length; j++)
            {
                if (arrayOf6Integers[j] % 2 == 0)
                {
                    sumOfEvenNumbers += arrayOf6Integers[j];
                }
                if (arrayOf6Integers[j] % 2 != 0)
                {
                    sumOfOddNumbers += arrayOf6Integers[j];
                }
            }
            Console.WriteLine($"The sum of even numbers is equal to: {sumOfEvenNumbers}");
            Console.WriteLine($"The sum of odd numbers is equal to: {sumOfOddNumbers}");

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
