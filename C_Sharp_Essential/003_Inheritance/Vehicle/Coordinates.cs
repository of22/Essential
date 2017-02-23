namespace DocumentWorker
{
    public class Coordinates
    {
        public float Latitude { get; set; }
        public float Longtitude { get; set; }

        public Coordinates(float latitude, float longtitude)
        {
            Latitude = latitude;
            Longtitude = longtitude;
        }
    }
}
