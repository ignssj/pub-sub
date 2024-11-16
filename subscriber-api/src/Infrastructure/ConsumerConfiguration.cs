using consumer_api.src.Application;
using MassTransit;

namespace consumer_api.src.Infrastructure
{
    public static class ConsumerConfiguration
    {
        public static void AddSubscriber(this IServiceCollection services, String uri, String username, String password)
        {
            services.AddMassTransit(x =>
            {
                x.AddConsumer<MessageConsumer>();
                x.UsingRabbitMq((context, cfg) =>
                {
                    cfg.Host(uri, h =>
                    {
                        h.Username(username);
                        h.Password(password);
                    });
                    cfg.ConfigureEndpoints(context);
                });
            });
        }
    }
}