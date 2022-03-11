using System;

namespace RealCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double input_1;
            double input_2;
            string operation;
            double result;

            // Input 1 
            Console.WriteLine("Please enter your first number: ");
            input_1 = Convert.ToInt32(Console.ReadLine());
            
            // Input 2
            Console.WriteLine("Please enter your second number: ");
            input_2 = Convert.ToInt32(Console.ReadLine());

            // Operation
            Console.WriteLine("Please enter your operation ( +, - , * , / )");
            operation = Console.ReadLine();

            // If else 

            if (operation == "+")
            {
                result = input_1 + input_2;
                Console.WriteLine(input_1 + " + " + input_2 + " = " + result);
            }
            else if (operation == "-")
            {
                result = input_1 - input_2;
                Console.WriteLine(input_1 + " - " + input_2 + " = " + result);
            }
            else if (operation == "*")
            {
                result = input_1 * input_2;
                Console.WriteLine(input_1 + " x " + input_2 + " = " + result);
            }
            else if (operation == "/")
            {
                result = input_1 / input_2;
                Console.WriteLine(input_1 + " / " + input_2 + " = " + result);
                
            }
            else
            {
                Console.WriteLine("Error!");
            }


            // The above code will cause an exception check version 2.0 :) --->>

            



        }
    }
}
