using System;

namespace TaskTwoApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter a sentence: ");

            ShowWords(Console.ReadLine());

            static string[] ShowWords(string input)
            {
                string[] result = input.Split(' ');

                Console.WriteLine($"You have {result.Length} words in your sentence, and they are:");

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($"{i + 1}) {result[i]}");
                }
                return result;
            }
        }
    }
}