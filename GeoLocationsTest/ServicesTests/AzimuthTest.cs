using GeoLocations.Entities;
using GeoLocations.Services;
using NUnit.Framework;

namespace GeoLocationsTest.ServicesTests
{
    public class AzimuthTest
    {
        [Test]
        public void Azimuth_GetAzimuth_Method_ReturnsAzimuthDegrees()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);

            Azimuth azimuth = new Azimuth();
            
            var azimuthDegrees =  azimuth.GetAzimuth(coordinateOne, coordinateTwo);
            
            Assert.Positive(azimuthDegrees);
            Assert.AreEqual(178.62832160199014, azimuthDegrees);
        }
    }
}