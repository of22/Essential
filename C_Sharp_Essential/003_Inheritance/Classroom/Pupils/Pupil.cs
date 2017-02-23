namespace Classroom.Pupils
{
    using System;

    public abstract class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil is studying");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil is reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil is writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil is relaxing");
        }
    }
}
