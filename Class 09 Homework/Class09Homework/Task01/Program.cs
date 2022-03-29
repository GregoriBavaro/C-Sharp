using System;

using System.Collections.Generic;

namespace Task01
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Queue<int> intInput = new Queue<int>();

            Console.WriteLine("Please enter your 5 numbers");

            int number;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Please enter number {i + 1}: ");

                while (!int.TryParse(Console.ReadLine(), out number))

                {
                    Console.WriteLine("Invalid Number, try again.");
                    Console.Write($"Please enter number {i + 1}: ");
                }

                intInput.Enqueue(number);
            }

            Console.WriteLine("Your numbers are: ");

            foreach (var numbers in intInput)
            {
                Console.WriteLine(numbers);
            }
        }
    }
}