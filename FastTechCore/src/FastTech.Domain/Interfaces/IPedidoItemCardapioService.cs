using FastTech.Domain.Entities;

namespace FastTech.Domain.Interfaces;

public interface IPedidoItemCardapioService : IBaseService<PedidoItemCardapio>
{
    Task<PedidoItemCardapio> GetById(Guid id, bool include, bool tracking);
    Task Remove(Guid id);
}