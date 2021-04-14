using System;
using System.Collections.Generic;
using System.Text;
using Task3.Enums;

namespace Task3.Classes
{
    public class Animal
    {
        public string AnimalKind { get; set; }
        public string AnimalName { get; set; }
        public string AnimalColor { get; set; }
        public int AnimalAge { get; set; }
        public GenderEnum AnimalGender { get; set; }

        public Animal(string kind, string name, string color, int age, GenderEnum gender)
        {
            AnimalKind = kind;
            AnimalName = name;
            AnimalColor = color;
            AnimalAge = age;
            AnimalGender = gender;
        }
    }
}
