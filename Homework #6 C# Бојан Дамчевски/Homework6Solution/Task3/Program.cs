using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task3.Classes;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Animal("Dog","Barney","Brown",3,Enums.GenderEnum.Male),
                new Animal("Cat","July","White",2,Enums.GenderEnum.Female),
                new Animal("Bear","Yogi","Brown",6,Enums.GenderEnum.Male),
                new Animal("Tiger","Larissa","Orange",7,Enums.GenderEnum.Female),
                new Animal("Dog","Tommy","Black",5,Enums.GenderEnum.Male),
                new Animal("Lion","Simba","Brown",6,Enums.GenderEnum.Male),
                new Animal("Lion","Lana","Brown",4,Enums.GenderEnum.Female),
                new Animal("Racoon","Moysey The Great","Black",10,Enums.GenderEnum.Male),
                new Animal("Cat","Bob","Black",7,Enums.GenderEnum.Male),
                new Animal("Dog","Ada","Gray",5,Enums.GenderEnum.Female),
                new Animal("Squirel","Johny","Brown",1,Enums.GenderEnum.Male),
                new Animal("Rabbit","Henry","White",6,Enums.GenderEnum.Male)
            };

            List<string> agedAbove5 = animals.Where(animal => animal.AnimalAge > 5)
                .Select(animal => $"Animal name: {animal.AnimalName}, Animal kind: {animal.AnimalKind}, Animal age: {animal.AnimalAge}")
                .ToList();
            Console.WriteLine("Animals with age above 5:");
            int counter = 1;
            int counter1 = 1;
            int counter2 = 1;
            foreach (string animal in agedAbove5)
            {
                Console.WriteLine("{0}. {1}", counter, animal);
                counter++;
            }

            Console.WriteLine("===========================================");

            List<string> namesThatStartWithA = animals.Where(animal => animal.AnimalName.StartsWith("A"))
                .Select(animal => animal.AnimalName)
                .ToList();
            Console.WriteLine("Animals with a name starting with the letter A:");
            foreach (string animal in namesThatStartWithA)
            {
                Console.WriteLine("{0}. {1}", counter1, animal);
                counter1++;
            }

            Console.WriteLine("===========================================");

            List<string> maleAndBrownAnimals = animals.Where(animal => animal.AnimalGender == Enums.GenderEnum.Male && animal.AnimalColor == "Brown")
                .Select(animal => $"Animal name: {animal.AnimalName}, Animal gender: {animal.AnimalGender}, Animal color: {animal.AnimalColor}")
                .ToList();
            foreach (string animal in maleAndBrownAnimals)
            {
                Console.WriteLine("{0}. {1}", counter2, animal);
                counter2++;
            }

            Console.WriteLine("===========================================");

            Animal animalWithNameMoreThan10Characters = animals.FirstOrDefault(animal => animal.AnimalName.Length > 10);
            Console.WriteLine("The animal with a name that has more than 10 characters: {0}",animalWithNameMoreThan10Characters.AnimalName);

            Console.ReadLine();
        }
    }
}
