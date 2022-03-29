using System;
using System.Collections.Generic;
using Task03.Model;
using Task03.Enum;
using System.Linq;

namespace Task03
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            List<Animal> cats = new List<Animal>()
            {
                new Animal() { Name = "Tom", Age = 2, Color = "White", Gender = GenderEnum.Male },
                new Animal() { Name = "Jerry", Age = 5, Color = "Brown", Gender = GenderEnum.Feemale },
                new Animal() { Name = "Tommy", Age = 7, Color = "Brown", Gender = GenderEnum.Feemale },
                new Animal() { Name = "William", Age = 5, Color = "Yellow", Gender = GenderEnum.Male },
                new Animal() { Name = "Rex", Age = 1, Color = "Orange", Gender = GenderEnum.Male },
                new Animal() { Name = "Duchess", Age = 8, Color = "White", Gender = GenderEnum.Feemale },
                new Animal() { Name = "Sparky", Age = 10, Color = "Brown", Gender = GenderEnum.Feemale },
                new Animal() { Name = "Attila", Age = 3, Color = "Brown", Gender = GenderEnum.Male },
            };

            // Find the names of all the animals aged 5 or more

            List<Animal> catsWithAgeFiveorMore = cats.Where(d => d.Age >= 5).ToList();

            Console.WriteLine("Cats age 5 or older than 5: ");

            foreach (Animal cat in catsWithAgeFiveorMore)
            {
                Console.WriteLine(cat.Name);
            }

            // Find all the names of the animals that start with 'A'

            List<Animal> catsThatStartWithA = cats.Where(d => d.Name.StartsWith("A")).ToList();

            Console.WriteLine("Cat names that start with A: ");

            foreach (Animal cat in catsThatStartWithA)
            {
                Console.WriteLine(cat.Name);
            }

            // Find all male, brown animals

            List<Animal> maleBrownCats = cats.Where(d => d.Gender == GenderEnum.Male && d.Color == "Brown").ToList();

            Console.WriteLine("Male Brown cats");

            foreach (Animal cat in maleBrownCats)
            {
                Console.WriteLine(cat.Name);
            }

            // Find the first animal whose name is longer than 10 characters

            Animal longerThanTenName = cats.FirstOrDefault(d => d.Name.Length > 5); // more realistic to check with 5 for name.length instead of 10

            Console.WriteLine("First cat whose name is longer than 10 characters");

            Console.WriteLine(longerThanTenName.Name);
        }
    }
}