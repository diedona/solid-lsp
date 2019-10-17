using DDona.Solid.LSP.Model;
using DDona.Solid.LSP.Model.Specialization;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DDona.Solid.LSP.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager() { FirstName = "Ray", LastName = "Nana", HourRate = 25, WorkHours = 200, Bonus = 1250 };
            Employee employee1 = new Employee() { FirstName = "John", LastName = "Doe", HourRate = 12.5, WorkHours = 120 };
            Intern intern1 = new Intern() { FirstName = "Johny", LastName = "Like" };
            CEO ceo1 = new CEO() { FirstName = "Luck", LastName = "Lucky", HourRate = 35, WorkHours = 200, SalaryMultiplier = 1.4 };

            List<BaseEmployee> employees = new List<BaseEmployee>() { intern1, employee1, manager1, ceo1 };
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.DoWork());
            }

            ///////////////////////////////////////////////////

            Console.WriteLine("------------");

            ///////////////////////////////////////////////////

            List<IPaidEmployee> paidEmployees = new List<IPaidEmployee>() { manager1, employee1, ceo1 };
            foreach (var paidEmployee in paidEmployees)
            {
                Console.WriteLine($"{paidEmployee.GetFullName()} has a salary of {paidEmployee.CalculateSalary().ToString("C2")}");
            }
        }
    }
}
