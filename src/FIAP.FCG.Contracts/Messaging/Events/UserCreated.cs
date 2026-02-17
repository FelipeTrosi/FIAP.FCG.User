namespace FIAP.FCG.Contracts.Messaging.Events;

public interface UserCreated
{
    long UserId { get; }
    string Email { get; }
    string Name { get; }
    DateTime Timestamp { get; }
}
