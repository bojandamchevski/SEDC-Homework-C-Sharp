using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average number");

            Console.WriteLine("Enter four numbers!");

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            //Moze i vaka
            //double num1 = double.Parse(input1);
            //double num2 = double.Parse(input2);
            //double num3 = double.Parse(input3);
            //double num4 = double.Parse(input4);

            double num1;
            double num2;
            double num3;
            double num4;

            bool num1Success = double.TryParse(input1, out num1);
            bool num2Success = double.TryParse(input2, out num2);
            bool num3Success = double.TryParse(input3, out num3);
            bool num4Success = double.TryParse(input4, out num4);

            Console.WriteLine($"Is the conversion successfull: {num1Success}");
            Console.WriteLine($"Is the conversion successfull: {num2Success}");
            Console.WriteLine($"Is the conversion successfull: {num3Success}");
            Console.WriteLine($"Is the conversion successfull: {num4Success}");

            double sum = num1 + num2 + num3 + num4;
            double result = sum / 4;

            Console.WriteLine($"The average of the four numbers you have entered is: {result}");
            Console.ReadLine();
        }
    }
}
