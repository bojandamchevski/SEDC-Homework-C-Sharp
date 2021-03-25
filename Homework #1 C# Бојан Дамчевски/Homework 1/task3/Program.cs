using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap numbers");
            Console.WriteLine("Enter two numbers");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            double num1 = Convert.ToDouble(input1);
            double num2 = Convert.ToDouble(input2);

            Console.WriteLine("Before swap");
            Console.WriteLine("First number is " + num1);
            Console.WriteLine("Second number is " + num2);

            num1 = Convert.ToDouble(input2);
            num2 = Convert.ToDouble(input1);

            Console.WriteLine("After swap");
            Console.WriteLine("First number is " + num1);
            Console.WriteLine("Second number is " + num2);

            Console.ReadLine();
        }
    }
}
