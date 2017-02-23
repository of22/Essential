namespace Vehicle.Entities
{
    using System;
    using DocumentWorker;

    class Plane : Vehicle
    {
        public int Height { get; }
        public int Passengeers { get; }

        public Plane(Coordinates coordinates, int price, int speed, int year, int height, int passengeers) : base(coordinates, price, speed, year)
        {
            Height = height;
            Passengeers = passengeers;
        }

        public override void PrintInformation()
        {
            Console.WriteLine("asdasdasd");
        }
    }
}
