namespace Vehicle.Entities
{
    using System;

    class Ship : Vehicle
    {
        public string Port { get; }
        public int Passengers { get; }

        public Ship(Coordinates coordinates, int price, int speed, int year, int passengers, string port) : base(coordinates, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override void PrintInformation()
        {
            Console.WriteLine($"Coordinates: Latitude = {Coordinates.Latitude}, Longtitude = {Coordinates.Longtitude}. Price = {Price}, Speed = {Speed}, Year = {Year}"
                             + $"\nHeight = {Port}, passengers = {Passengers}");
        }
    }
}
