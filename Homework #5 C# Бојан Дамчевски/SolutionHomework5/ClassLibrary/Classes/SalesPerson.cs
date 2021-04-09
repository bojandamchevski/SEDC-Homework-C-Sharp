using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary.Enums;

namespace ClassLibrary.Classes
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue { get; set; }
        public void AddSuccessRevenue(int revenue)
        {
            _successSaleRevenue = revenue;
        }
        public override double GetSalary()
        {
            if (_successSaleRevenue <= 0)
            {
                Console.WriteLine("No Revenue, no Salary, sorry...");
            }
            else
            {
                if (_successSaleRevenue <= 2000)
                {
                    Salary += 500;
                }
                else if (_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
                {
                    Salary += 1000;
                }
                else if (_successSaleRevenue > 5000)
                {
                    Salary += 1500;
                }
                else
                {
                    Salary = Salary;
                }
            }
            return Salary;
        }
        public SalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = RoleEnum.Sales;
            Salary = 500;
        }
    }
}
