namespace Vehicle.Entities
{
    using System;

    class Plane : Vehicle
    {
        public int Height { get; }
        public int Passengers { get; }

        public Plane(Coordinates coordinates, int price, int speed, int year, int height, int passengers) : base(coordinates, price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"Coordinates: Latitude = {Coordinates.Latitude}, Longtitude = {Coordinates.Longtitude}. Price = {Price}, Speed = {Speed}, Year = {Year}"
                + $"\nHeight = {Height}, passengers = {Passengers}");
        }
    }
}
