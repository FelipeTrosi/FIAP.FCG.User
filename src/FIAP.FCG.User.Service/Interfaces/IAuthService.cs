using FIAP.FCG.User.Service.Dto.Login;

namespace FIAP.FCG.User.Service.Interfaces;

public interface IAuthService
{
    string Login(LoginDto input);
}
