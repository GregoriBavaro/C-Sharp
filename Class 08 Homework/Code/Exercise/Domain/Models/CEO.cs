using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class CEO : Employee
    {
        public string[] Employees { get; set; }

        public int Shares { get; set; }

        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, int shares, string[] employees)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Shares = shares;
            Employees = employees;
        }

        public double AddSharesPrice(double number)
        {
            SharesPrice += number;

            return SharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees: ");

            foreach (string employees in Employees)
            {
                Console.WriteLine(employees);
            }
        }

        public override double GetSalary()
        {
            Salary += (Shares * SharesPrice);
            Console.WriteLine($"Salary of CEO is: {Salary}");
            return Salary;
        }
    }
}