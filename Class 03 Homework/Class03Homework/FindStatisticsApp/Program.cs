using System;

namespace FindStatisticsApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            bool parseResult_1 = int.TryParse(Console.ReadLine(), out int input_1);

            Console.Write("Please enter your second number: ");
            bool parseResult_2 = int.TryParse(Console.ReadLine(), out int input_2);

            int answer;

            if (parseResult_1 && parseResult_2)
            {
                if (input_1 % 2 == 0 && input_2 % 2 == 0)
                {
                    answer = input_1 + input_2;
                    Console.WriteLine($"{input_1} + {input_2} = {answer}");
                }
                if (input_1 % 2 == 1 && input_2 % 2 == 1)
                {
                    answer = input_1 * input_2;
                    Console.WriteLine($"{input_1} x {input_2} = {answer}");
                    ;
                }
                else if (input_1 % 2 == 1 || input_2 % 2 == 1)
                {
                    answer = input_1 - input_2;
                    Console.WriteLine($"One of the numbers is odd. The operation and result are {input_1} - {input_2} = {answer}");
                }
            }
            else
            {
                Console.WriteLine("Invalid! Please enter only numbers.");
            }
        }
    }
}