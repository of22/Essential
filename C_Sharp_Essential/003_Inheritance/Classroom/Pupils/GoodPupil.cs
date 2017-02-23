namespace Classroom.Pupils
{
    using System;

    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good Pupil is ");
        }

        public override void Read()
        {
            Console.WriteLine("Good Pupil is reading");
        }

        public override void Write()
        {
            Console.WriteLine("Good Pupil is writing");
        }

        public override void Relax()
        {
            Console.WriteLine("Good Pupil is relaxing");
        }
    }
}
