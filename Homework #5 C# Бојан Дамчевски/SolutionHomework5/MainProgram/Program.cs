using System;
using ClassLibrary.Enums;
using ClassLibrary.Classes;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Kate", "Kateson");
            Manager manager2 = new Manager("Bob", "Bobson");
            SalesPerson salesperson1 = new SalesPerson("John", "Smith");
            Contractor contractor1 = new Contractor("Bill", "Billson", 5.5, 300, manager1);
            Contractor contractor2 = new Contractor("Jill", "Jillson", 3.5, 400, manager2);

            contractor1.GetSalary();
            contractor2.GetSalary();
            manager1.AddBonus();
            manager2.AddBonus();
            manager1.GetSalary();
            manager2.GetSalary();
            salesperson1.AddSuccessRevenue(25000);
            salesperson1.GetSalary();

            Employee[] company =
            {
                manager1,
                manager2,
                salesperson1,
                contractor1,
                contractor2
            };

            CEO ceoNumber1 = new CEO("Frank", "Frink", 2313, company);

            double ceoSalary = ceoNumber1.GetSalary();
            string infoCEO = ceoNumber1.PrintInfo();
            Console.WriteLine(infoCEO);
            Console.WriteLine("Employees: ");
            ceoNumber1.PrintEmployees();
            Console.ReadLine();
        }
    }
}
