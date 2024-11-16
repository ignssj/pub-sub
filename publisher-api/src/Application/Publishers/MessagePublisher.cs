using MassTransit;
using publisher_api.src.Domain.Interfaces;
using publisher_api.src.Domain.Entities;

namespace publisher_api.src.Application
{
    public class MessagePublisher(IBus bus) : IPublisher
    {
        public async Task PublishAsync(string description)
        {
            var message = new MessageRequested
            {
                Description = description,
                CreatedAt = DateTime.Now
            };

            await bus.Publish(message);
        }
    }
}