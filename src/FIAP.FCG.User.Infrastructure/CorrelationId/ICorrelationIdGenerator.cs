namespace FIAP.FCG.User.Infrastructure.CorrelationId;

public interface ICorrelationIdGenerator
{
    string Get();
    void Set(string correlationId);
}
