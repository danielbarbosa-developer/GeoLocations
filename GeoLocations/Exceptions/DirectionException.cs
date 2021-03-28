using System;

namespace GeoLocations.Exceptions
{
    public class DirectionException : Exception
    {
        public DirectionException()
        {
        }
        public DirectionException(string message) : base(message)
        {
        }
        public DirectionException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}