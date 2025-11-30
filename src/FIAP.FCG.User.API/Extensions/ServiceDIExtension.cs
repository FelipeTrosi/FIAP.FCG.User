using FIAP.FCG.User.API.Services;
using FIAP.FCG.User.Infrastructure.Logger;
using FIAP.FCG.User.Service.Interfaces;
using FIAP.FCG.User.Service.Services;

namespace FIAP.FCG.User.API.Extensions; 

public static class ServiceDIExtension
{
    public static IServiceCollection AddServiceDI(this IServiceCollection services)
    {
        services.AddTransient(typeof(IBaseLogger<>), typeof(BaseLogger<>));
        services.AddTransient<IAuthService, AuthService>();

        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IGameService, GameService>();

        return services;
    }
}
