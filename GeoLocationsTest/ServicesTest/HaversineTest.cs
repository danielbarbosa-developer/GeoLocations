using GeoLocations.Entities;
using GeoLocations.Measures;
using GeoLocations.Services;
using NUnit.Framework;

namespace GeoLocationsTest.ServicesTest
{
    public class HaversineTest
    {
        [Test]
        public void Haversine_Distance_Method_ReturnsDistanceKilometers()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
            Haversine haversine = new Haversine();

            double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.Kilometers);

            Assert.Greater(distance, 0);
            Assert.Positive(distance);
            Assert.AreEqual(26.527347380913824, distance);
        }
        [Test]
        public void Haversine_Distance_Method_ReturnsDistanceMiles()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
            Haversine haversine = new Haversine();

            double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.Miles);

            Assert.Greater(distance, 0);
            Assert.Positive(distance);
            Assert.AreEqual(16.48850975175306, distance);
        }
        [Test]
        public void Haversine_Distance_Method_ReturnsDistanceNauticalMiles()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
            Haversine haversine = new Haversine();

            double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.NauticalMiles);

            Assert.Greater(distance, 0);
            Assert.Positive(distance);
            Assert.AreEqual(14.323351905563264, distance);
        }
        [Test]
        public void Haversine_Distance_Method_ReturnsDistanceMeters()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
            Haversine haversine = new Haversine();

            double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.Meters);

            Assert.Greater(distance, 0);
            Assert.Positive(distance);
            Assert.AreEqual(26527.347380913823, distance);
        }
    }
}