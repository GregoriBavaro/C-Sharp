using Domain.Enums;

namespace Domain.Models
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue { get; set; }

        public SalesPerson()
        {
        }

        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Salary = 500;
            Role = RoleEnum.Sales;
        }

        public void AddSuccessRevenue(double revenue)
        {
            _successSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                return Salary + 500;
            }

            if (_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }

            return Salary + 1500;
        }
    }
}