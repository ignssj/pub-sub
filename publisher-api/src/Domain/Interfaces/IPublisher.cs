namespace publisher_api.src.Domain.Interfaces
{
    public interface IPublisher
    {
        Task PublishAsync(String description);
    }
}