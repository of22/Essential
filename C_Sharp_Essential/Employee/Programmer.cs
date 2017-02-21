namespace Employee
{
    using System;

    class Programmer : Employee, ITaxable
    {
        public Programmer(string name, string surname) : base(name, surname)
        {
        }

        public override void GetEmployeeInfo()
        {
            Console.WriteLine($"Employee name and surname : {this.Name}, {Surname}");
        }

        public void SetUserDetails(string position, string salary, string taxes, string experience)
        {
            Position = position;
            Salary = salary;
            Taxes = taxes;
            Experience = experience;
        }

        public void CalculateTax(int tax)
        {
            throw new NotImplementedException();
        }
    }
}
