using System;

namespace RealCalculatorApp2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            // Version 2.0 fixes replaces the if and else statement with the switch statement, with that it dries the code and makes it more readable. Most inportant in this version i introduced TryParse which wont make the program crash and will return an error when an invalid char is used.

            string operation;
            string answer;
            double input_1;
            double input_2;

            Console.WriteLine("Welcome to version 2.0 of 'Real Calculator App'");
            Console.Write("Please enter your 1st number: ");

            while (!Double.TryParse(Console.ReadLine(), out input_1))
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Write("Please enter your 1st number: ");
            }
            Console.Write("Please enter your second number: ");
            while (!Double.TryParse(Console.ReadLine(), out input_2))
            {
                Console.WriteLine("Invalid input, please try again");
                Console.Write("Please enter your 2nd number: ");
            }
            Console.Write("Please enter your operator ( x , / , +, -) ");
            operation = Console.ReadLine();
            answer = Calculate(input_1, input_2, operation);
            Console.WriteLine(answer);

        }
        static string Calculate(double input_1, double input_2, string operation)
        {
            double answer = 0;

            switch (operation)
            {
                case "x":
                    answer = input_1 * input_2;
                    break;
                case "/":
                    answer = input_1 / input_2;
                    break;
                case "+":
                    answer = input_1 + input_2;
                    break;
                case "-":
                    answer = input_1 - input_2;
                    break;
                default:
                    return "Invalid format, Please restart and try again";

            }
            return $"{input_1} {operation} {input_2} = {answer}";
        }
    }
}
