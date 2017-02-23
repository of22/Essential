namespace Vehicle
{
    using System;
    using System.Collections.Generic;
    using Entities;

    class Program
    {
        //Создать класс Vehicle.
        //В теле класса создайте поля:  координаты и параметры средств передвижения(цена, скорость, год выпуска).  
        //Создайте 3 производных класса Plane, Саг и Ship.
        //Для класса Plane должна быть определена высота и количество пассажиров.
        //Для класса Ship — количество пассажиров и порт приписки.
        //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

        static void Main()
        {
            IList<Vehicle> list = new List<Vehicle>
            {
                new Plane(new Coordinates(2f, 2f), 2000000, 2000, 2005, 10000, 220),
                new Ship(new Coordinates(3f, 3f), 1000000, 100, 2000, 230, "Maldives"),
                new Car(new Coordinates(5f,5f), 4000, 160, 2005 )
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
