using System;
using System.Linq;

namespace TaskFourApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // In this task i wanted to push myself even further and learn something new. I add a few more methods to sort the array and even though it was not asked to get the data from promped i used promped so i can practice more complex code :)
            // Getting the values from promped in strings

            string[] stringArrayFromUser = new string[10];

            Console.WriteLine("Please enter 10 numbers: ");

            // Looping promped to cut code
            for (int i = 0; i < stringArrayFromUser.Length; i++)
            {
                stringArrayFromUser[i] = Console.ReadLine();
            }

            // Converting the string array to number array

            int[] parsedToInt = Array.ConvertAll(stringArrayFromUser, s => int.TryParse(s, out int x) ? x : 0); // used the 0 as a deafult value if the ConvertAll method throws an exception because of promped input value that cant be converted from string to int.

            // Showing the original array
            Console.WriteLine("Original array: ");
            foreach (int i in parsedToInt)
            {
                Console.Write(i + " ");
            }

            // Using sort method to ASC order
            Console.WriteLine("\nArray in Ascending Order :");
            Array.Sort(parsedToInt);
            foreach (int i in parsedToInt)
            {
                Console.Write(i + " ");
            }

            // Using sort method to DESC order
            Console.WriteLine("\nArray in Descending Order :");
            Array.Reverse(parsedToInt);
            foreach (int i in parsedToInt)
            {
                Console.Write(i + " ");
            }

            // Find maximum
            Console.Write($"\nThe largest number is: {parsedToInt.Max()}");

            // Find minimum
            Console.Write($"\nThe smalest number is: {parsedToInt.Min()}");
        }
    }
}