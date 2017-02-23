namespace Vehicle.Entities
{
    using System;
    using DocumentWorker;
    using Interfaces;

    //Создать класс Vehicle.
    //В теле класса создайте поля:  координаты и параметры средств передвижения(цена, скорость, год выпуска).  
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

    public abstract class Vehicle : IInformable
    {
        public Coordinates Coordinates { get; set; }
        private int Price { get; }
        private int Speed { get; }
        public int Year { get; }

        protected Vehicle(Coordinates coordinates, int price, int speed, int year)
        {
            Coordinates = coordinates ?? new Coordinates(2.22f, 2.33f);
            Price = price;
            Speed = speed;
            Year = year;
        }

        public abstract void PrintInformation();
//        {
//            Console.WriteLine(ToString());
//        }

        public override string ToString()
        {
            return
                $"Coordinates: Latitude = {Coordinates.Latitude}, Longtitude = {Coordinates.Longtitude}. Price = {Price}, Speed = {Speed}, Year = {Year}";
        }
    }
}
