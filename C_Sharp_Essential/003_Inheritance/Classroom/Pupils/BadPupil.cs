namespace Classroom.Pupils
{
    using System;

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad Pupil is not studying");
        }

        public override void Read()
        {
            Console.WriteLine("Bad Pupil is not reading");
        }

        public override void Write()
        {
            Console.WriteLine("Bad Pupil is not writing");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad Pupil is relaxing");
        }
    }
}
