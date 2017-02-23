namespace Vehicle.Entities
{
    using System;

    //Создать класс Vehicle.
    //В теле класса создайте поля:  координаты и параметры средств передвижения(цена, скорость, год выпуска).  
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

    public class Vehicle 
    {
        public Coordinates Coordinates { get; set; }
        protected int Price { get; }
        protected int Speed { get; }
        public int Year { get; }

        protected Vehicle(Coordinates coordinates, int price, int speed, int year)
        {
            Coordinates = coordinates ?? new Coordinates(2.22f, 2.33f);
            Price = price > 0 ? price : 1;
            Speed = speed;
            Year = year;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine($"Coordinates: Latitude = {Coordinates.Latitude}, Longtitude = {Coordinates.Longtitude}. Price = {Price}, Speed = {Speed}, Year = {Year}");
        }

    }
}
