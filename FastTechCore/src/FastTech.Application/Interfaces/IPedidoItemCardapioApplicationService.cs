using FastTech.Application.DataTransferObjects;
using FastTech.Application.Interfaces.RabbitMQ;

namespace FastTech.Application.Interfaces;

public interface IPedidoItemCardapioApplicationService
{
    Task<PedidoItemCardapio> GetById(Guid id);
    Task<PedidoItemCardapio> Add(BasicPedidoItemCardapio model);
    Task<PedidoItemCardapio> Update(PedidoItemCardapio model);
}