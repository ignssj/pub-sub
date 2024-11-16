using MassTransit;
using publisher_api.src.Domain.Entities;

namespace publisher_api.src.Infrastructure
{
    public static class PublisherConfiguration
    {
        public static IServiceCollection AddPublisher(this IServiceCollection services, String uri, String username, String password)
        {
            services.AddMassTransit(x =>
            {
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
            return services;
        }
    }
}