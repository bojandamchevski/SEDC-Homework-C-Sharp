using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real Calculator");
            Console.WriteLine("Enter two numbers !");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            double num1;
            double num2;

            bool num1Success = double.TryParse(input1, out num1);
            bool num2Success = double.TryParse(input2, out num2);

            Console.WriteLine($"Is the first conversion successfull:{num1Success}");
            Console.WriteLine($"Is the second conversion successfull:{num2Success}");

            Console.WriteLine($"The first number is {num1}");
            Console.WriteLine($"The second number is {num2}");

            double result;
            Console.WriteLine("Enter operator (+,-,*,/)");
            string operation = Console.ReadLine();
            switch (operation){
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("The result is " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine("The result is " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine("The result is " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine("The result is " + result);
                    break;
                default:
                    Console.WriteLine("Wrong input, try again !");
                    break;
            }
            Console.ReadLine();
        }
    }
}
