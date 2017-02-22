namespace Employee
{
    abstract class Employee
    {

        //Создать класс Employee.
        //В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
        //Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
        //Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

        protected string Name { get; }
        protected string Surname { get; }

        protected string Position { get; set; }
        protected double Salary { get; set; }
        protected int Experience { get; set; }

        protected Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public abstract void GetEmployeeInfo();

        public double CalculateTax()
        {
            if (Experience > 5)
            {
                return Salary / 100 * 3;
            }
            if (Position == "manager" & Salary > 5000)
            {
                return Salary / 100 * 10;
            }
            return Salary / 100 * 5;
        }

        protected double CalculateGrossSalary()
        {
            return Salary + CalculateTax();
        }

    }
}
