namespace Employee
{
    using System;

    abstract class Employee
    {

        //Создать класс Employee.
        //В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
        //Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
        //Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

        string Name { get; }
        string Surname { get; }

        protected string Position { get; set; }
        protected string Salary { get; set; }
        protected string Taxes { get; set; }
        protected int Experience { get; set; }

        protected Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public abstract void GetEmployeeInfo();
        
    }
}
