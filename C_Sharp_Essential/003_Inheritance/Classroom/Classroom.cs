namespace Classroom
{
    using System.Collections.Generic;
    using Pupils;

    class Classroom
    {
        private List<Pupil> Pupils { get; } = new List<Pupil>(4);

        public Classroom(Pupil pupil1, Pupil pupil2)
        {
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(PupilGenerator.GenerateRandomPupil());
            Pupils.Add(PupilGenerator.GenerateRandomPupil());
        }

        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(pupil3);
            Pupils.Add(PupilGenerator.GenerateRandomPupil());
        }

        public Classroom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Pupils.Add(pupil1);
            Pupils.Add(pupil2);
            Pupils.Add(pupil3);
            Pupils.Add(pupil4);
        }

        public void StartPupilActivities()
        {
            foreach (Pupil pupil in Pupils)
            {
                pupil.Read();
            }

            foreach (Pupil pupil in Pupils)
            {
                pupil.Write();
            }

            foreach (Pupil pupil in Pupils)
            {
                pupil.Study();
            }

            foreach (Pupil pupil in Pupils)
            {
                pupil.Relax();
            }

        }

    }
    
}
