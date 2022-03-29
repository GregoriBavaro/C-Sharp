using System;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            List<int> integersList = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                integersList.Add(random.Next(1, 100));
            }

            foreach (var integers in integersList)
            {
                Console.WriteLine(integers);
            }

            List<int> squaredNumbers = (List<int>)integersList.Select(x => x * x).ToList();

            Console.WriteLine("Squared numbers");

            foreach (var item in squaredNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}