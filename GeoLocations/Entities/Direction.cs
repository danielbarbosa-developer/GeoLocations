namespace GeoLocations.Entities
{
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
        public string DirectionName { get; set; }
        public string Abbreviation { get; set; }
        
    }
}