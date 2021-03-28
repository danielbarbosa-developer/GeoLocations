using System;
using System.Collections.Generic;
using GeoLocations.Entities;
using GeoLocations.Exceptions;
using GeoLocations.Rules;

namespace GeoLocations.Services
{
    public class Directions
    {
        public Direction GetDirection(double azimuthAngle)
        {
            if (azimuthAngle >= 337.5 || azimuthAngle <= 22.5) return DirectionSetter.North;
            if (azimuthAngle > 22.5 && azimuthAngle <= 67.5) return DirectionSetter.Northeast;
            if (azimuthAngle > 67.5 && azimuthAngle <= 112.5) return DirectionSetter.East;
            if (azimuthAngle > 112.5 && azimuthAngle <= 157.5) return DirectionSetter.Southeast;
            if (azimuthAngle > 157.5 && azimuthAngle <= 202.5) return DirectionSetter.South;
            if (azimuthAngle > 202.5 && azimuthAngle <= 247.5) return DirectionSetter.Southwest;
            if (azimuthAngle > 247.5 && azimuthAngle <= 292.5) return DirectionSetter.West;
            if (azimuthAngle > 292.5 && azimuthAngle < 337.5) return DirectionSetter.Northwest;
            throw new DirectionException("Could not find any azimuth angle");
        }
    }
}