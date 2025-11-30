using FIAP.FCG.User.API.Middleware;

namespace FIAP.FCG.User.API.Extensions;

public static class LogMiddlewareExtensions
{
    public static IApplicationBuilder UseLogMiddleware(this IApplicationBuilder builder)
        => builder.UseMiddleware<LogMiddleware>();

}