using GeoLocations.Entities;
using GeoLocations.Measures;
using GeoLocations.Services;
using NUnit.Framework;

namespace GeoLocationsTest.ServicesTests
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
            Assert.AreEqual(26.55715993894982, distance);
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
            Assert.AreEqual(16.501854618862748, distance);
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
            Assert.AreEqual(14.339719666127442, distance);
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
            Assert.AreEqual(26557.159938949822, distance);
        }
        [Test]
        public void Haversine_Distance_Method_ReturnsDistanceFoot()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
            Haversine haversine = new Haversine();

            double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.Foot);

            Assert.Greater(distance, 0);
            Assert.Positive(distance);
            Assert.AreEqual(87129.789826879787, distance);
        }
        [Test]
        public void Haversine_Distance_Method_ReturnsDistanceKiloYard()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
            Haversine haversine = new Haversine();

            double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.KiloYard);

            Assert.Greater(distance, 0);
            Assert.Positive(distance);
            Assert.AreEqual(29.043264961951454, distance);
        }
        [Test]
        public void Haversine_Distance_Method_ReturnsDistanceYard()
        {
            GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
            GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
            Haversine haversine = new Haversine();

            double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.Yard);

            Assert.Greater(distance, 0);
            Assert.Positive(distance);
            Assert.AreEqual(29043.263275626592, distance);
        }
    }
}