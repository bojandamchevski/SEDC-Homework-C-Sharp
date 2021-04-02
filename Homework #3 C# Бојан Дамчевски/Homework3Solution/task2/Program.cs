using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");

            Console.WriteLine("Please type a sentence.");

            string inputSentence = Console.ReadLine();

            string trimmedSentence = inputSentence.Trim();

            string[] onlyWordsFromSentence = trimmedSentence.Split(" ");

            Console.WriteLine("The words in the sentence are: ");
            foreach(string word in onlyWordsFromSentence)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
