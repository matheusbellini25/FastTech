using FastTechKitchen.Application.DataTransferObjects.MessageBrokers;

namespace FastTechKitchen.Api.Robots.RabbitMQ
{
    public interface IPedidoConsumerService
    {
        Task<List<Pedido>> GetPedidosAsync();
    }
}
