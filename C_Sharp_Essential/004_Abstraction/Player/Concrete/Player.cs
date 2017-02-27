namespace Player.Concrete
{
    using System;
    using Interfaces;
    public class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Started playing");
        }

        public void Record()
        {
            Console.WriteLine("Started recording");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Paused recording");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Stopped recording");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Paused playing");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stopped playing");
        }
    }
}
