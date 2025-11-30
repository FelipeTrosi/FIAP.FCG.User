using FIAP.FCG.User.Infrastructure.CorrelationId;

namespace FIAP.FCG.User.API.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddCorrelationIdGenerator(this IServiceCollection services)
    {
        services.AddTransient<ICorrelationIdGenerator, CorrelationIdGenerator>();

        return services;
    }
}
