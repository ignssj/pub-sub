using MassTransit;

namespace publisher_api.src.Infrastructure
{
    public static class BusConfiguration
    {
        public static IServiceCollection AddObserver(this IServiceCollection services, String uri, String username, String password)
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