using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Task4Bonus.Classes;

namespace Task4Bonus
{
    class Program
    {
        static void GetDictionary(List<Employee> employeeList)
        {
            Dictionary<int, List<string>> newDictionary = new Dictionary<int, List<string>>();

            foreach (Employee person in employeeList)
            {
                if (newDictionary.ContainsKey(person.Age))
                {
                    List<string> newList = newDictionary[person.Age];
                    newList.Add($"{person.FirstName} {person.LastName}");
                    newDictionary[person.Age] = newList;
                }
                else
                {
                    newDictionary.Add(person.Age, new List<string>() { $"{person.FirstName} {person.LastName}" });
                }
            }

            foreach (var item in newDictionary)
            {
                Console.WriteLine(item.Key);
                foreach (var fullname in item.Value)
                {
                    Console.WriteLine(fullname + "\n");
                }
            }
        }
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("John", "Smith", 40);
            Employee employee2 = new Employee("Helen", "Smith", 37);
            Employee employee3 = new Employee("Frank", "Frink", 32);
            Employee employee4 = new Employee("Juliana", "Crane", 29);
            Employee employee5 = new Employee("Joey", "Tribianni", 27);
            Employee employee6 = new Employee("Chandler", "Bing", 24);
            Employee employee7 = new Employee("Rachel", "Green", 24);
            Employee employee9 = new Employee("Monica", "Geller", 26);
            Employee employee8 = new Employee("Ross", "Geller", 28);
            Employee employee10 = new Employee("Phoebe", "Buffay", 26);

            List<Employee> employees = new List<Employee>()
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10
            };

            GetDictionary(employees);

            Console.ReadLine();
        }
    }
}
