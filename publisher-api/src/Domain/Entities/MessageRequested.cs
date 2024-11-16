namespace publisher_api.src.Domain.Entities
{
    public class MessageRequested
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}