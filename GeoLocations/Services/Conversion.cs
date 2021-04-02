using System;

namespace GeoLocations.Services
{
    /// <summary>
    /// A class that provides conversion methods to common measures used to work with coordinates
    /// </summary>
    public class Conversion
    {
        /// <summary>
        /// Converts radian value to a azimuth angle
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static double ToAzimuthAngle(double radian)
        {
            return (ToDegree(radian) + 360) % 360;
        }
        /// <summary>
        /// Convert coordinate degrees to radian
        /// </summary>
        /// <param name="degree"></param>
        /// <returns></returns>
        public static double ToRadian(double degree)
        {
            return (Math.PI / 180) * degree;
        }
        /// <summary>
        /// Convert radian to coordinate degrees
        /// </summary>
        /// <param name="radian"></param>
        /// <returns></returns>
        public static double ToDegree(double radian)
        {
            return radian * 180 / Math.PI;
        }
    }
}