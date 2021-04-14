using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void EnterNumbers(int numberOfElements)
        {
            bool flag1 = true;
            while (flag1)
            {
                Console.WriteLine("You have to enter {0} elements in the Queue", numberOfElements);
                Queue<double> numbers = new Queue<double>();
                int counter = 0;
                while (counter < numberOfElements)
                {
                    Console.WriteLine("Enter the number with index {0}", counter);
                    bool success = double.TryParse(Console.ReadLine(), out double number);
                    if (success)
                    {
                        numbers.Enqueue(number);
                        counter++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input please try again !");
                    }
                }
                Console.WriteLine("Here are the numbers in the order you have entered them:");
                foreach (double num in numbers)
                {
                    Console.WriteLine(num);
                }
                flag1 = false;
            }
        }
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter number of elements !");
                bool successElements = int.TryParse(Console.ReadLine(), out int elementsNumber);
                if (successElements)
                {
                    EnterNumbers(elementsNumber);
                    flag = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input please try again !");
                }
            }

            Console.ReadLine();
        }
    }
}
