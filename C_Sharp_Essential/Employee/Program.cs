using System;

namespace Employee
{
    class Program
    {
        //Создать класс Employee.
        //В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника.
        //Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор.
        //Написать программу, которая выводит на экран информацию о сотруднике(фамилия, имя, должность), оклад и налоговый сбор.

        static void Main()
        {
            Programmer programmer = new Programmer("Vasiliy", "Vasiliev");

            programmer.SetUserDetails("programmer", 3000d, 10);

            Console.WriteLine(programmer.ToString());
            Console.Write("\nPress any key to quit . . . ");
            Console.ReadKey();

        }
    }
}
