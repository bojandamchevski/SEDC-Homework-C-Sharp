using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        protected double Salary { get; set; }
        public string PrintInfo()
        {
            return $"First Name: {FirstName}\nLast Name: {LastName}\nRole: {Role}\nSalary: {Salary}";
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
