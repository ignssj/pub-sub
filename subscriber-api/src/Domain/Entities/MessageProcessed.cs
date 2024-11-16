namespace consumer_api.src.Domain.Entities
{
    public class MessageProcessed
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ProcessedAt { get; set; } = null;
    }
}