using MassTransit;

namespace FIAP.FCG.User.API.Extensions;

public static class MassTransitExtension
{
    public static IServiceCollection UseMassTransit(this IServiceCollection services, IConfiguration configuration)
    {
        var host = Environment.GetEnvironmentVariable("RABBITMQ_HOST");
        var user = Environment.GetEnvironmentVariable("RABBITMQ_USER");
        var pass = Environment.GetEnvironmentVariable("RABBITMQ_PASS");

        services.AddMassTransit(x =>
        {
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host("rabbitmq", "/", h =>
                {
                    h.Username(user!);
                    h.Password(pass!);
                });
            });
        });

        return services;
    }
}
