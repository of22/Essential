namespace Classroom
{
    using System;
    using Pupils;

    public static class PupilGenerator
    {

        public static Pupil GenerateRandomPupil()
        {
            Random random = new Random();

            int result = random.Next(1, 4);

            switch (result)
            {
                case 1:
                    return new BadPupil();
                case 2:
                    return new GoodPupil();
                case 3:
                    return new ExcellentPupil();
            }
            return new BadPupil();
        }

    }
}
