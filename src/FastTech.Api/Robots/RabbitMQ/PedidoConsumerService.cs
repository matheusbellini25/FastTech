using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using FastTech.Application.DataTransferObjects.MessageBrokers;
using FastTech.Api.Robots.RabbitMQ;

public class PedidoConsumerService : IPedidoConsumerService
{
    private readonly IConfiguration _configuration;

    public PedidoConsumerService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<List<Pedido>> GetPedidosAsync()
    {
        var pedidos = new List<Pedido>();

        var rabbitConfig = _configuration.GetSection("RabbitMQ");

        var factory = new ConnectionFactory
        {
            HostName = rabbitConfig["HostName"],
            UserName = rabbitConfig["UserName"],
            Password = rabbitConfig["Password"],
            Port = int.TryParse(rabbitConfig["Port"], out var port) ? port : 5672
        };

        using var connection = await factory.CreateConnectionAsync();
        using var channel = await connection.CreateChannelAsync();

        var queueName = rabbitConfig["QueueName"];
        var consumer = new AsyncEventingBasicConsumer(channel);

        var tcs = new TaskCompletionSource<List<Pedido>>();

        consumer.ReceivedAsync += async (sender, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            try
            {
                var lista = JsonSerializer.Deserialize<List<Pedido>>(message, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (lista != null)
                    pedidos.AddRange(lista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar: {ex.Message}");
            }

            tcs.TrySetResult(pedidos);
            await Task.CompletedTask;
        };

        await channel.BasicConsumeAsync(queue: queueName, autoAck: true, consumer: consumer);

        // Aguarda a primeira mensagem ou timeout
        var result = await Task.WhenAny(tcs.Task, Task.Delay(5000)); // timeout opcional

        return tcs.Task.IsCompleted ? tcs.Task.Result : new List<Pedido>();
    }
}
