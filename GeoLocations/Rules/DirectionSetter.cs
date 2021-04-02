using GeoLocations.Entities;

namespace GeoLocations.Rules
{
    public static class DirectionSetter
    {
        /// <summary>
        /// A Direction object setted as North
        /// </summary>
        public static Direction North
        {
            get { return new Direction("North", "N"); }
        }
        /// <summary>
        /// A Direction object setted as Northeast
        /// </summary>
        public static Direction Northeast
        {
            get { return new Direction("Northeast", "NE"); }
        }
        /// <summary>
        /// A Direction object setted as East
        /// </summary>
        public static Direction East
        {
            get { return new Direction("East", "E"); }
        }
        /// <summary>
        /// A Direction object setted as Southeast
        /// </summary>
        public static Direction Southeast
        {
            get { return new Direction("Southeast", "SE"); }
        }
        /// <summary>
        /// A Direction object setted as South
        /// </summary>
        public static Direction South
        {
            get { return new Direction("South", "S"); }
        }
        /// <summary>
        /// A Direction object setted as Southwest
        /// </summary>
        public static Direction Southwest
        {
            get { return new Direction("Southwest", "SW"); }
        }
        /// <summary>
        /// A Direction object setted as West
        /// </summary>
        public static Direction West
        {
            get { return new Direction("West", "W"); }
        }
        /// <summary>
        /// A Direction object setted as Northwest
        /// </summary>
        public static Direction Northwest
        {
            get { return new Direction("Northwest", "NW"); }
        }
    }
}