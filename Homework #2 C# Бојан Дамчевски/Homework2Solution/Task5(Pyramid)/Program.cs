using System;

namespace Task5_Pyramid_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Pyramid");

            int i, j, space, numOfRows = 5, k, t = 1;

            space = numOfRows + 4 - 1;
            for (i = 1; i < numOfRows; i++)
            {
                for (k = space; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.WriteLine();
                space--;
            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
