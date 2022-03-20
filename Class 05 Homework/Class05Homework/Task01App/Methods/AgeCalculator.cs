using System;
using System.Collections.Generic;
using System.Text;

namespace Task01App.Methods
{
    internal static class AgeCalculator
    {
        internal static int AgeCalc(DateTime userInput)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - userInput.Year;
            if (today.Month < userInput.Month || (today.Month == userInput.Month && today.Day < userInput.Day))
            {
                age--;
            }
            return age;
        }
    }
}