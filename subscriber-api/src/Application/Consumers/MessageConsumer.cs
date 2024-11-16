using System.Text.Json;
using consumer_api.src.Domain.Entities;
using MassTransit;

namespace consumer_api.src.Application
{
    public class MessageConsumer : IConsumer<MessageRequested>
    {
        public async Task Consume(ConsumeContext<MessageRequested> context)
        {
            Console.WriteLine("Processing request...");

            await Task.Delay(5000);

            Console.WriteLine($"MessageRequested event consumed. Message: {context.Message.Description}");
        }
    }
}