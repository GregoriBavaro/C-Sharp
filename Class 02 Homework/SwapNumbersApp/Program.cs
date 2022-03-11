using System;

namespace SwapNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_1, input_2, temp;

            Console.Write("Please enter the 1st number: ");
            while (!Int32.TryParse(Console.ReadLine(), out input_1))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter the 1st number: ");
            }

            Console.Write("Please enter the 2nd number: ");
            while (!Int32.TryParse(Console.ReadLine(), out input_2))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter the 2ndt number: ");
            }

            temp = input_1;
            input_1 = input_2;
            input_2 = temp;

            Console.WriteLine("The following numbers have been swapped: ");
            Console.WriteLine($"First number: {input_1}");
            Console.WriteLine($"Second number: {input_2}");
        }
    }
}
