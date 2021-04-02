using GeoLocations.Services;
using NUnit.Framework;

namespace GeoLocationsTest.ServicesTests
{
    public class DirectionsTest
    {
        [Test]
        public void Directions_GetDirection_Method_ReturnsDirectionObject()
        {
            Directions directions = new Directions();
            var direction = directions.GetDirection(170);
            
            Assert.AreEqual("S", direction.Abbreviation);
            Assert.AreEqual("South",direction.DirectionName);
        }
    }
}