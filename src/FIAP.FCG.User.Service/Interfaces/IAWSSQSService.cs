namespace FIAP.FCG.User.Service.Interfaces;

public interface IAWSSQSService
{
    Task PublishAsync(string userId, string email, string name);
}
