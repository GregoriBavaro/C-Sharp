using System;
using Domain.Enums;
using Domain.Models;

namespace Exercise
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Contractor contractor01 = new Contractor
            {
                FirstName = "Bob",
                LastName = "Bobert",
                WorkHours = 40,
                PayPerHour = 22
            };

            Contractor contractor02 = new Contractor
            {
                FirstName = "Rick",
                LastName = "Rickeret",
                WorkHours = 80,
                PayPerHour = 22
            };

            Manager manager01 = new Manager
            {
                FirstName = "Mona",
                LastName = "Monalisa"
            };

            Manager manager02 = new Manager
            {
                FirstName = "Igor",
                LastName = "Igorsky"
            };

            SalesPerson sale = new SalesPerson
            {
                FirstName = "Lea",
                LastName = "Leova"
            };

            object[] company = new object[5] { contractor01, contractor02, manager01, manager02, sale };

            CEO ceo = new CEO("Ron", "Ronsky", 800, 30, new string[] { "Bob Bobert", "Rick Rickert", "Mona Monalisa", "Igor Igorsky", "Lea Leova" });

            Console.WriteLine("CEO:");

            ceo.AddSharesPrice(350);
            ceo.PrintInfo();
            ceo.GetSalary();
            ceo.PrintEmployees();
        }
    }
}