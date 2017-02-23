namespace Classroom.Pupils
{
    using System;

    class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excellent Pupil is studying");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent Pupil is reading");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent Pupil is writing");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent Pupil is relaxing");
        }
    }
}
