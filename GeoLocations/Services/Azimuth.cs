using System;
using GeoLocations.Entities;

namespace GeoLocations.Services
{
    public class Azimuth
    {
        public double GetAzimuth(GeoCoordinate origin, GeoCoordinate destiny)
        {
            double destinyRadian = Conversion.ToRadian((destiny.Longitude - origin.Longitude));
            double destinyPi = Math.Log(Math.Tan(Conversion.ToRadian(destiny.Latitude) / 2 + Math.PI / 4) / Math.Tan(Conversion.ToRadian(origin.Latitude) / 2 + Math.PI / 4));
            
            if (Math.Abs(destinyRadian) > Math.PI)
                destinyRadian = destinyRadian > 0
                    ? -(2 * Math.PI - destinyRadian)
                    : (2 * Math.PI + destinyRadian);
            
            return Conversion.ToAzimuthAngle(Math.Atan2(destinyRadian, destinyPi));
        }
    }
}