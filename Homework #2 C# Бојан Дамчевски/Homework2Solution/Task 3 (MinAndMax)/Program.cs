using System;

namespace Task_3__MinAndMax_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum and maximum");

            int[] numbers = new int[] { -23, -4, -22, -56, -124, -12, 0, -78, -3, -1, -34 };

            int min = numbers[0], max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= max)
                {
                    max = numbers[i];
                }
                if (numbers[i] <= min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine($"The maximum number from the array of numbers is {max}");
            Console.WriteLine($"The minimum number from the array of numbers is {min}");

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
