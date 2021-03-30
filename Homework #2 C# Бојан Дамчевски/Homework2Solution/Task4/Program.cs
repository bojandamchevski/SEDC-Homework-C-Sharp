using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements in array.");
            string inputNumElements = Console.ReadLine();
            bool successInputNumElements = int.TryParse(inputNumElements, out int numberOfElements);

            int[] arrayOfNumbers = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter element.");
                arrayOfNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int k = 0;

            for (int j = 0; j < arrayOfNumbers.Length - 1; j++)
            {
                if (arrayOfNumbers[j] == 3 && arrayOfNumbers[j + 1] == 3)
                {
                    k++;
                }
            }

            Console.WriteLine($"The number 3 has occured {k} times");

            Console.WriteLine(arrayOfNumbers);

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
