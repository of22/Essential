namespace Employee
{
    using System;

    class Programmer : Employee
    {
        public Programmer(string name, string surname) : base(name, surname)
        {
        }

        public override void GetEmployeeInfo()
        {
            Console.WriteLine();
        }

        public void SetUserDetails(string position, double salary, int experience)
        {
            Position = position;
            Salary = salary;
            Experience = experience;
        }

        public override string ToString()
        {
            return
                $"Employee name and surname : {Name}, {Surname} " +
                $"\nSalary = {Salary} USD" +
                $"\nPosition = {Position} " +
                $"\nExperience = {Experience} year(s)" +
                $"\nTax amount (per month) = {CalculateTax()} USD" +
                $"\nGross Salary = {CalculateGrossSalary()} USD";
        }
    }
}
