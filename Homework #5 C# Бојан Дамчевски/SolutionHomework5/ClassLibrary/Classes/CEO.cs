using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Classes
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public void AddSharesPrice(double sharesPriceNew)
        {
            SharesPrice += sharesPriceNew;
        }
        public void PrintEmployees()
        {
            foreach (Employee person in Employees)
            {
                Console.WriteLine(person.PrintInfo());
                Console.WriteLine(person.Role + "\n===============");
            }
        }
        public override double GetSalary()
        {
            Salary = Salary + Shares * SharesPrice;
            return Salary;
        }
        public CEO(string firstName, string lastName, int shares, Employee[] employeesList) : base(firstName, lastName)
        {
            Salary = 5000;
            Role = RoleEnum.CEO;
            FirstName = firstName;
            LastName = lastName;
            Shares = shares;
            Employees = employeesList;
            SharesPrice = 100000;
        }
    }
}
