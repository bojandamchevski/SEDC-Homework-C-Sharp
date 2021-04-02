using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4");

            Console.WriteLine("Enter an operator.");

            bool success1 = char.TryParse(Console.ReadLine(), out char opera);
            
            Console.WriteLine("Enter first number.");
            bool success2 = double.TryParse(Console.ReadLine(), out double num1);


            Console.WriteLine("Enter second number.");
            bool success3 = double.TryParse(Console.ReadLine(), out double num2);

            if(!success1 || !success2 || !success3)
            {
                throw new Exception("Invalid input!");
            }
            else
            {
                Calculator(opera, num1, num2);
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
        static double Sum(double num1, double num2)
        {
            double sum = 0;
            sum = num1 + num2;
            return sum;
        }
        static double Substract(double num1, double num2)
        {
            double sub = 0;
            sub = num1 - num2;
            return sub;
        }
        static double Multiplication(double num1, double num2)
        {
            double multi = 0;
            multi = num1 * num2;
            return multi;
        }
        static double Division(double num1, double num2)
        {
            double div = 0;
            div = num1 / num2;
            return div;
        }
        static void Calculator(char inputOperator, double number1, double number2)
        {
            switch (inputOperator)
            {
                case '+':
                    Console.WriteLine($"The sum of the numbers is: {Sum(number1, number2)}");
                    break;
                case '-':
                    Console.WriteLine($"The difference of the numbers is: {Substract(number1, number2)}");
                    break;
                case '*':
                    Console.WriteLine($"The multiplication of the numbers is: {Multiplication(number1, number2)}");
                    break;
                case '/':
                    Console.WriteLine($"The division of the numbers is: {Division(number1, number2)}");
                    break;
            }
        }
    }
}
