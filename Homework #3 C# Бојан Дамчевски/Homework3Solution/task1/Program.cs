using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");

            Console.WriteLine("Please enter some text.");

            string input = Console.ReadLine();

            string trimmedInput = input.Trim();

            char[] charArrayOfInput = trimmedInput.ToCharArray();

            Console.WriteLine("The string backwards is: ");
            for (int i = charArrayOfInput.Length - 1; i >= 0; i--)
            {
                Console.Write(charArrayOfInput[i] + "   ");
            }

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
