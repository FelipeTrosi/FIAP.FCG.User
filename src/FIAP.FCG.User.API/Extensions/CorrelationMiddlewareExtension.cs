using FIAP.FCG.User.Infrastructure.Middlewares;

namespace FIAP.FCG.User.API.Extensions;

public static class CorrelationMiddlewareExtension
{
    public static IApplicationBuilder UseCorrelationMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CorrelationMiddleware>();
    }
}
