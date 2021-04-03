# `GeoLocations`
A Nuget package created to work with geographic coordinates.

![Build Status](https://github.com/danielbarbosa-developer/GeoLocations/actions/workflows/dotnet.yml/badge.svg)
[![NuGet](https://img.shields.io/nuget/v/GeoLocations.svg)](https://nuget.org/packages/GeoLocations)
[![Nuget](https://img.shields.io/nuget/dt/GeoLocations.svg)](https://nuget.org/packages/GeoLocations)
### New in Version 2.0.0

* Moving to .NET Standard;

## Download GeoLocations Package

This package is available on Nuget:
https://www.nuget.org/packages/GeoLocations/

## Using GeoLocations Package

### Entities
The package allows working with Coordinates objects, to create a GeoCoordinate object see the example below:

```c#
using GeoLocations.Entities;

namespace YourNamespace
{
    public class YourClass
    {
        // Creating GeoCoordinates objects...
        GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
        GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
    }
}

```
### Services
The Package offers classes of services for working with coordinates and performing useful operations.
#### Haversine Class
This class allows to get distance between two coordinates points, see the example below:

```c#
using GeoLocations.Entities;
using GeoLocations.Services;
using GeoLocations.Measures;

namespace YourNamespace
{
    public class YourClass
    {
        // Creating GeoCoordinates objects...
        GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
        GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
        
        // Working with Haversine class to get distance between two points
        Haversine haversine = new Haversine();
        double distance = haversine.Distance(coordinateOne, coordinateTwo, DistanceMeasure.Kilometers);
    }
}
```

Note that you must pass three parameters to the Distance method, the first two parameters are coordinate objects, the third parameter is the unit of measurement available in the DistanceMeasure enum.
The result will be in the chosen unit of measure.

#### Azimuth Class
This class allows you to find the azimuth angle from an origin coordinate to a destination coordinate using the GetAzimuth method:
```c#
using GeoLocations.Entities;
using GeoLocations.Services;

namespace YourNamespace
{
    public class YourClass
    {
        // Creating GeoCoordinates objects...
        GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
        GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
        
        // Working with Azimuth class to get the azimuth angle and later the direction of the destiny
         Azimuth azimuth = new Azimuth();
         double azimuthAngle =  azimuth.GetAzimuth(coordinateOne, coordinateTwo);
    }
}
```
#### Directions Class
With the azimuth angle you can find the cardinal direction (N, NW, W, etc.) to a destination coordinate:
```c#
using GeoLocations.Entities;
using GeoLocations.Services;

namespace YourNamespace
{
    public class YourClass
    {
        // Creating GeoCoordinates objects...
        GeoCoordinate coordinateOne = new GeoCoordinate(-27.59457134301226, -48.56909738264723);
        GeoCoordinate coordinateTwo = new GeoCoordinate(-27.833069147090193, -48.5626465445453);
        
        // Working with Azimuth class to get the azimuth angle and later the direction of the destiny
        Azimuth azimuth = new Azimuth();
        double azimuthAngle =  azimuth.GetAzimuth(coordinateOne, coordinateTwo);
         
        // Find the destiny direction with Directions class
        Directions directions = new Directions();
        Direction direction = directions.GetDirection(azimuthAngle);
    }
}
```
The result is a Direction object, and you can access its properties:
```c#
Direction direction = directions.GetDirection(azimuthAngle);

string directionName = direction.DirectionName;
string abbreviation = direction.Abbreviation;
```





