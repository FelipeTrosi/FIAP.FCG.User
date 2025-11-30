using FIAP.FCG.User.Domain.Entity;

namespace FIAP.FCG.User.Infrastructure.Repository.Interfaces;

public interface IUserRepository : IRepository<UserEntity>
{
    UserEntity? GetByUserAndPassword(string user, string password);
}
