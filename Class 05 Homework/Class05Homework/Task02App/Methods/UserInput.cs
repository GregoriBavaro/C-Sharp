using System;

namespace Task02App.Methods
{
    internal class UserInput
    {
        internal static string GetFirstName()
        {
            Console.Write("Please Enter your First Name: ");
            string name = Console.ReadLine();

            return name;
        }

        internal static string GetLastName()
        {
            Console.Write("Please Enter your Last Name: ");
            string lastName = Console.ReadLine();

            return lastName;
        }

        internal static int GetAge()
        {
            Console.Write("Please Enter your Age: ");
            string age = Console.ReadLine();

            int AgeParsed = int.Parse(age);

            return AgeParsed;
        }
    }
}