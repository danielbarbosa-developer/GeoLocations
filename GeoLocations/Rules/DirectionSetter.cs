using GeoLocations.Entities;

namespace GeoLocations.Rules
{
    public static class DirectionSetter
    {
        public static Direction North
        {
            get { return new Direction("North", "N"); }
        }
        public static Direction Northeast
        {
            get { return new Direction("Northeast", "NE"); }
        }
        public static Direction East
        {
            get { return new Direction("East", "E"); }
        }
        public static Direction Southeast
        {
            get { return new Direction("Southeast", "SE"); }
        }
        public static Direction South
        {
            get { return new Direction("South", "S"); }
        }
        public static Direction Southwest
        {
            get { return new Direction("Southwest", "SW"); }
        }
        public static Direction West
        {
            get { return new Direction("West", "W"); }
        }
        public static Direction Northwest
        {
            get { return new Direction("Northwest", "NW"); }
        }
    }
}