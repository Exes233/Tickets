using System.ComponentModel.DataAnnotations;

namespace WebAppLab3.Models
{
    public class ContactUsEntry
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
