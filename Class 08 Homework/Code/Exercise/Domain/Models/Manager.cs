using Domain.Enums;

namespace Domain.Models
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }

        public Manager()
        {
        }

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = RoleEnum.Manager;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}