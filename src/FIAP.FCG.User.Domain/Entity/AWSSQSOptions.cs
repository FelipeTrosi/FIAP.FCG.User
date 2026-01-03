namespace FIAP.FCG.User.Domain.Entity;

public class AWSSQSOptions
{
    public string QueueUrl { get; set; } = null!;
    public string Region { get; set; } = null!;
    public string AccessKey { get; set; } = null!;
    public string SecretKey { get; set; } = null!;
}
