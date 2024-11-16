namespace publisher_api.src.Domain.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ProcessedAt { get; set; } = null;
    }
}