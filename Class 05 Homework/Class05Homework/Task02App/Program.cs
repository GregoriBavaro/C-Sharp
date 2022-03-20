using System;
using Task02App.Models;
using Task02App.Methods;

namespace Task02App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Human human = new Human();
            human.Age = UserInput.GetAge();
            human.FirstName = UserInput.GetFirstName();
            human.LastName = UserInput.GetLastName();

            string info = human.GetPersonStats(human.FirstName, human.LastName, human.Age);

            Console.WriteLine(info);
        }
    }
}