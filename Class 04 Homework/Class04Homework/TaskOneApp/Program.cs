using System;

namespace TaskOneApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            PrintResult(Console.ReadLine());
        }

        private static string PrintResult(string input)
        {
            string formater = input.Substring(input.Length - 5);
            Console.Write($"The last 5 Characters of the word you entered are: {formater}");
            return formater;
        }
    }
}