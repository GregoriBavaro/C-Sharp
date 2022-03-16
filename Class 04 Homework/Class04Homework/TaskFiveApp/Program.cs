using System;

namespace TaskFiveApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int elements;
            Console.WriteLine("Enter only numbers from 1 to 9");
            Console.Write("\nPlease enter the number of elements: ");

            while (!int.TryParse(Console.ReadLine(), out elements))
            {
                Console.WriteLine("Invalid input, enter a number.");
                Console.Write("Please enter the number of elements: ");
            }

            int[] integersArray = new int[elements];

            for (int i = 0; i < integersArray.Length; i++)
            {
                int input;
                Console.Write($"Please enter value number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input, enter a number.");
                    Console.Write($"Please enter value number {i + 1}: ");
                }

                integersArray[i] = input;
            }

            Console.WriteLine(Test(integersArray));
        }

        private static string Test(int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == 3 && numbers[i + 1] == 3)

                {
                    counter++;
                }
            }

            string name = "";

            switch (counter)
            {
                case 1:
                    name = "One";
                    break;

                case 2:
                    name = "Two";
                    break;

                case 3:
                    name = "Three";
                    break;

                case 4:
                    name = "Four";
                    break;

                case 5:
                    name = "Five";
                    break;

                case 6:
                    name = "Six";
                    break;

                case 7:
                    name = "Seven";
                    break;

                case 8:
                    name = "Eight";
                    break;

                case 9:
                    name = "Nine";
                    break;
            }
            return $"{name} times there are {name}'s next to each other";
        }
    }
}