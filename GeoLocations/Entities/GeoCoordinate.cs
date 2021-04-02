namespace GeoLocations.Entities
{
    /// <summary>
    /// A model class of coordinates
    /// </summary>
    public class GeoCoordinate
    {
        public GeoCoordinate()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="latitude">Latitude decimal value</param>
        /// <param name="longitude">Longitude decimal value</param>
        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        /// <summary>
        /// The latitude decimal value
        /// </summary>
        public double Latitude { get; }
        /// <summary>
        /// The longitude decimal value
        /// </summary>
        public double Longitude { get; }
    }
}