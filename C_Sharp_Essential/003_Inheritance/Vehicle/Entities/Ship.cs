namespace Vehicle.Entities
{
    using System;
    using DocumentWorker;

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
            Console.WriteLine("asdasd");
            ;
        }
    }
}
