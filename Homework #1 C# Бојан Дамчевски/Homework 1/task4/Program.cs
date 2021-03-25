using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find statistics");
            Console.WriteLine("Enter two numbers");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int num1;
            int num2;

            bool num1Success = int.TryParse(input1, out num1);
            bool num2Success = int.TryParse(input2, out num2);

            Console.WriteLine("Is the conversion of the first number successfull " + num1Success);
            Console.WriteLine("Is the conversion of the second number successfull " + num2Success);

            if(num1 % 2 == 0 && num2 % 2 == 0)
            {
                int sum = num1 + num2;
                Console.WriteLine($"The numbers are even and their sum is {num1} + {num2} = {sum}");
            }
            else if(num1 % 2 == 0 || num2 % 2 == 0)
            {
                int difference = num1 - num2;
                Console.WriteLine($"One of the numbers is odd and their difference is {num1} - {num2} = {difference}");
            }
            else
            {
                int multi = num1 * num2;
                Console.WriteLine($"Both of the numbers are odd and their multiplication is {num1} * {num2} = {multi}");
            }

            Console.ReadLine();
        }
    }
}
