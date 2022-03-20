using System;
using System.Collections.Generic;
using System.Text;

namespace Task01App.Methods
{
    public static class InputFormating
    {
        public static DateTime GetInformation()
        {
            Console.Write("Hello, please enter your Birth-Day month/day/year : ");
            DateTime birthDay;
            while (!DateTime.TryParse(Console.ReadLine(), out birthDay))
            {
                Console.WriteLine("Invalid Input, please try again");
                Console.Write("Hello, please enter your Birth-Day month/day/year : ");
            }
            return birthDay;
        }
    }
}