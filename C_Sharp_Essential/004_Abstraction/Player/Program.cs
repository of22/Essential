namespace Player
{
    using System;
    using Concrete;
    using Interfaces;

    class Program
    {
        //Создайте 2 интерфейса IPlayable и IRecodable.В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
        //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
        //Написать программу, которая выполняет проигрывание и запись.

        static void Main()
        {

            Player player = new Player();
            IPlayable playable = player;
            IRecordable recordable = player;

            player.Play();
            playable.Pause();
            ((IPlayable)player).Stop();

            Console.WriteLine();

            recordable.Record();
            recordable.Pause();
            (player as IRecordable).Stop();

            Console.ReadLine();
        }
    }
}
