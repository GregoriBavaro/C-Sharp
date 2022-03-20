using System;
using Task01App.Methods;

namespace Task01App
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            DateTime dt = InputFormating.GetInformation();
            int age = AgeCalculator.AgeCalc(dt);
            Console.WriteLine($"You are {age} years old!");
        }
    }
}