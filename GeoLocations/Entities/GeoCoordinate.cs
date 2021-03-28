namespace GeoLocations.Entities
{
    public class GeoCoordinate
    {
        public GeoCoordinate()
        {
            
        }
        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public double Latitude { get; }
        public double Longitude { get; }
    }
}