namespace WebAppLab3.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<Seat> Seats { get; set; }
        public List<Comment> Comments { get; set; }
    }
    public class Seat
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public bool IsBooked { get; set; }
        public int Price { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
    }
}
