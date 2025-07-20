using FastTech.Domain.Entities;

namespace FastTech.Domain.Interfaces.Infrastructure;

public interface IPedidoItemCardapioRepository : IRepository<PedidoItemCardapio>
{
    Task<PedidoItemCardapio> GetById(Guid id, bool include = false, bool tracking = false);
}