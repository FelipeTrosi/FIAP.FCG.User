using FIAP.FCG.User.Domain.Enums.User;

namespace FIAP.FCG.User.Domain.Entity
{
    public class UserEntity : EntityBase
    {
        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public AccessLevelEnum AccessLevel { get; set; }
    }
}
