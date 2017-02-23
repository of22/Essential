namespace Vehicle
{
    using System;
    using System.Collections.Generic;
    using DocumentWorker;
    using Entities;
    using Interfaces;

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
            var plane = new Plane(new Coordinates(2f,2f),2,2,2,2,2);

            IList<Vehicle> list = new List<Vehicle>
            {
                new Plane(new Coordinates(2f,2f),2,2,2,2,2),
                new Ship(new Coordinates(2f,2f),2,2,2,2,"asd")
            };

            foreach (var informable in list)
            {
                Console.WriteLine(informable);
            }
            Console.ReadLine();

        }
    }
}
