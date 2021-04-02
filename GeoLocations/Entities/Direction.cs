namespace GeoLocations.Entities
{
    /// <summary>
    /// A model class of directions information, like name and abbreviation  
    /// </summary>
    public class Direction
    {
        public Direction()
        {
            
        }
        public Direction(string directionName, string abbreviation)
        {
            DirectionName = directionName;
            Abbreviation = abbreviation;
            
        }
        /// <summary>
        /// The direction complete name (Ex. North)
        /// </summary>
        public string DirectionName { get; set; }
        /// <summary>
        /// The direction abbreviation (Ex. N)
        /// </summary>
        public string Abbreviation { get; set; }
    }
}