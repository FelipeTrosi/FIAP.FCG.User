using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using FIAP.FCG.User.Domain.Entity;
using FIAP.FCG.User.Infrastructure.Logger;
using FIAP.FCG.User.Service.Interfaces;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace FIAP.FCG.User.Service.Services;

public class AWSSQSService(IBaseLogger<AWSSQSService> logger, IOptions<AWSSQSOptions> options) : IAWSSQSService
{
    private readonly IBaseLogger<AWSSQSService> _logger = logger;
    private readonly AWSSQSOptions _options = options.Value;

    public async Task PublishAsync(string userId, string email, string name)
    {
        _logger.LogInformation($"Iniciando chamada AWS SQS para envio do email: {email}");

        using var sqs = new AmazonSQSClient(new BasicAWSCredentials(_options.AccessKey, _options.SecretKey),
            RegionEndpoint.GetBySystemName(_options.Region));

        var messageBody = JsonSerializer.Serialize(new
        {
            UserId = userId,
            Email = email,
            Name = name
        });

        _logger.LogInformation($"Gravando na fila AWS SQS !");

        await sqs.SendMessageAsync(new SendMessageRequest
        {
            QueueUrl = _options.QueueUrl,
            MessageBody = messageBody
        });
    }
}
