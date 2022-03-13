using System;

namespace TaskThreeApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid number format");
                Console.Write("Please enter a number: ");
            }

            for (int i = 0; i < number; i++)
            {
                if (i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
                if (i >= 80)
                {
                    Console.WriteLine("Limit rached, cant print over 80");
                    break;
                }
            }
        }
    }
}