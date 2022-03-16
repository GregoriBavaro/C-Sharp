using System;

namespace TaskFourApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string operation;
            string answer;
            double input_1;
            double input_2;

            Console.WriteLine("Simple Calculator");
            Console.Write("Please enter your first number: ");

            while (!double.TryParse(Console.ReadLine(), out input_1))
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.Write("Please enter your first number: ");
            }

            Console.Write("Please enter your second number: ");

            while (!double.TryParse(Console.ReadLine(), out input_2))
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.Write("Please enter your second number: ");
            }

            Console.Write("Please enter your operator ( x , / , +, -) ");
            operation = Console.ReadLine();
            answer = Calculate(input_1, input_2, operation);
            Console.WriteLine(answer);
        }

        private static string Calculate(double input_1, double input_2, string operation)
        {
            double answer;

            switch (operation)
            {
                case "+":
                    answer = Sum(input_1, input_2);
                    break;

                case "-":
                    answer = Substract(input_1, input_2);
                    break;

                case "x":
                    answer = Multiplication(input_1, input_2);
                    break;

                case "/":
                    answer = Division(input_1, input_2);
                    break;

                default:
                    return "Invalid format, please restart the application and try again.";
            }
            return $"{input_1} {operation} {input_2} = {answer}";
        }

        private static double Sum(double number_1, double number_2)
        {
            return number_1 + number_2;
        }

        private static double Substract(double number_1, double number_2)
        {
            return number_1 - number_2;
        }

        private static double Multiplication(double number_1, double number_2)
        {
            return number_1 * number_2;
        }

        private static double Division(double number_1, double number_2)
        {
            return number_1 / number_2;
        }
    }
}