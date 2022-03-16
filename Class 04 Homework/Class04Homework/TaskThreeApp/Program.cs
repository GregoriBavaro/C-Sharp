using System;

namespace TaskThreeApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Enter a number to find the sum of the digits in that number.");
            Console.Write("Please enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input, please try again!");
                Console.Write("Please enter a number: ");
            }
            GetSum(input);
        }

        private static int GetSum(int input)
        {
            int result = 0;
            while (input != 0)
            {
                result += input % 10;
                input = input / 10;
            }
            Console.Write($"The sum of digits is: {result}");
            return result;
        }
    }
}