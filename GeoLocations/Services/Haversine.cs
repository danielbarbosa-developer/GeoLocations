using System;
using GeoLocations.Entities;
using GeoLocations.Measures;

namespace GeoLocations.Services
{
    /// <summary>
    /// A Class to work with Haversine equation 
    /// </summary>
    public class Haversine
    {
        /// <summary>
        /// Calculates the distance between two latitude / longitude points
        /// </summary>
        /// <param name="pos1">The first position</param>
        /// <param name="pos2">The second position</param>
        /// <param name="measureType">Specifies the type of measurement (Kilometers, Miles)</param>
        /// <returns>The distance in the measure type specified</returns>
        public double Distance(GeoCoordinate pos1, GeoCoordinate pos2, DistanceMeasure measureType)
        {
            double earthRadius = (measureType == DistanceMeasure.Miles) ? 3960 : 6371;
 
            double lat = ToRadian(pos2.Latitude - pos1.Latitude);
            double lon = ToRadian(pos2.Longitude - pos1.Longitude);
 
            double a = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
                       Math.Cos(ToRadian(pos1.Latitude)) *Math.Cos(ToRadian(pos2.Latitude)) *
                       Math.Sin(lon / 2) * Math.Sin(lon / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            double distance = earthRadius * c;
 
            return distance;
        }
 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private static double ToRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}