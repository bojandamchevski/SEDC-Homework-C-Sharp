using System;

namespace Task_2__StudentGroup_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StudentGroup");

            string[] studentsG1 = new string[] { "Rachel", "Ross", "Chandler", "Phoebe", "Monica" };
            string[] studentsG2 = new string[] { "Ted", "Marshall", "Lily", "Robin", "Barney" };

            Console.WriteLine("Enter the number 1 or 2 !");

            string input = Console.ReadLine();
            bool successNumber = int.TryParse(input, out int number);

            if (successNumber)
            {
                if (number == 1)
                {
                    Console.WriteLine("The students of G1 are:");
                    foreach(string nameOfStudents1 in studentsG1)
                    {
                        Console.WriteLine(nameOfStudents1);
                    }
                }
                else if(number == 2)
                {
                    Console.WriteLine("The students of G2 are:");
                    foreach (string nameOfStudents2 in studentsG2)
                    {
                        Console.WriteLine(nameOfStudents2);
                    }
                }
                else
                {
                    Console.WriteLine("The number is not 1 or 2 !!!");
                }
            }
            else
            {
                Console.WriteLine("Bad input !!!");
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
