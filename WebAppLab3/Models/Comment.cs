namespace WebAppLab3.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
