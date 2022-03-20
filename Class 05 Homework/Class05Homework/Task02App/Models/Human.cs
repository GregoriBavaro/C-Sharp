namespace Task02App.Models
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonStats(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            string personalInfo = $"{firstName} {lastName} is {age} years old";

            return personalInfo;
        }
    }
}