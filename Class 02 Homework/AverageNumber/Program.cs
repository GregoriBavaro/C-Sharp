using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input_1;
            int input_2;
            int input_3;
            int input_4;
            string answer;

            Console.WriteLine("Please enter 4 numbers to fine an average");
            Console.Write("Please enter your 1st number: ");

            while (!Int32.TryParse(Console.ReadLine(), out input_1))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter your 1st number: ");
            }

            Console.Write("Please enter your 2nd number: ");
            while (!Int32.TryParse(Console.ReadLine(), out input_2))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter your 2nd number: ");
            }

            Console.Write("Please enter your 3rd number: ");
            while (!Int32.TryParse(Console.ReadLine(), out input_3))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter your 3rd number: ");
            }

            Console.Write("Please enter your 4th number: ");
            while (!Int32.TryParse(Console.ReadLine(), out input_4))
            {
                Console.WriteLine("Invalid number, please try again");
                Console.Write("Please enter your 4th number: ");
            }

            answer = Calculate(input_1, input_2, input_3, input_4);
            Console.WriteLine(answer);
        }

        static string Calculate(int input_1, int input_2, int input_3, int input_4)
        {
            int answer = 0;

            answer = input_1 + input_2 + input_3 + input_4;

            return $"{input_1} + {input_2} + {input_3} + {input_4} = {answer}";
        }
    }
}
