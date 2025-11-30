using FIAP.FCG.User.Domain.Entity;
using FIAP.FCG.User.Infrastructure.Repository.Interfaces;

namespace FIAP.FCG.User.Infrastructure.Repository
{
    public class GameRepository : EFRepository<GameEntity>, IGameRepository
    {
        public GameRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
