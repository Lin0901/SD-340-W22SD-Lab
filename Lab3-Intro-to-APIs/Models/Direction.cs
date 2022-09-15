namespace Lab3_Intro_to_APIs.Models
{
    public class Direction
    {
        public int Id { get; set; }
        public enum DirectionEnum
        {
            North,
            South,
            East,
            West,
            Northeast,
            Northwest, 
            Southeast,
            Southwest
        } 
    }
}
