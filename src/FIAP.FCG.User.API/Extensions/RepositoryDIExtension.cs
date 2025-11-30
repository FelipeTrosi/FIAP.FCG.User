using FIAP.FCG.User.Infrastructure.Repository;
using FIAP.FCG.User.Infrastructure.Repository.Interfaces;

namespace FIAP.FCG.User.API.Extensions
{
    public static class RepositoryDIExtension
    {
        public static IServiceCollection AddRepositoryDI(this IServiceCollection services)
        {
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
