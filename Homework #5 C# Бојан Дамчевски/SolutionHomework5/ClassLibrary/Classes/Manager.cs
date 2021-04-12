using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Classes
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }
        public void AddBonus()
        {
            _bonus = new Random().Next(3000, 5000);
        }
        public override double GetSalary()
        {
            return Salary + _bonus;
        }
        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = RoleEnum.Manager;
            Salary = 1000;
        }
    }
}
