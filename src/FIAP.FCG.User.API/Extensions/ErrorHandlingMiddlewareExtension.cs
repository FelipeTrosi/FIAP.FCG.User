using FIAP.FCG.User.API.Middleware;

namespace FIAP.FCG.User.API.Extensions;

public static class ErrorHandlingMiddlewareExtension
{
    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ErrorHandlingMiddleware>();
    }
}
