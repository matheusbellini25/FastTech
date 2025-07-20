using AutoMapper;
using FastTech.Application.DataTransferObjects;
using FastTech.Domain.Constants;
using FastTech.Domain.Interfaces;
using System.Text.Json;
using EN = FastTech.Domain.Entities;
using MSG = FastTech.Application.DataTransferObjects.MessageBrokers;

namespace FastTech.Application.Services;

public class PedidoItemCardapioApplicationService(IPedidoItemCardapioService pedidoItemCardapioService, IMapper mapper) : Interfaces.IPedidoItemCardapioApplicationService
{
    private readonly IPedidoItemCardapioService _PedidoItemCardapioService = pedidoItemCardapioService;
    private readonly IMapper _mapper = mapper;

    public async Task<PedidoItemCardapio> Add(BasicPedidoItemCardapio model)
    {
        var PedidoItemCardapio = _mapper.Map<EN.PedidoItemCardapio>(model);

        PedidoItemCardapio = await _PedidoItemCardapioService.Add(PedidoItemCardapio);

        return _mapper.Map<PedidoItemCardapio>(PedidoItemCardapio);
    }

    public async Task<PedidoItemCardapio> Update(PedidoItemCardapio model)
    {
        var PedidoItemCardapio = await _PedidoItemCardapioService.GetById(model.Id, include: false, tracking: true);
        if (PedidoItemCardapio == null)
            throw new Exception("O Item do Cardapio não existe.");

        _mapper.Map(model, PedidoItemCardapio);

        PedidoItemCardapio = await _PedidoItemCardapioService.Update(PedidoItemCardapio);

        return _mapper.Map<PedidoItemCardapio>(PedidoItemCardapio);
    }

    public async Task<PedidoItemCardapio> Add(MSG.BasicPedidoItemCardapio model)
    {
        var PedidoItemCardapio = _mapper.Map<EN.PedidoItemCardapio>(model);

        PedidoItemCardapio = await _PedidoItemCardapioService.Add(PedidoItemCardapio);

        return _mapper.Map<PedidoItemCardapio>(PedidoItemCardapio);
    }

    public async Task<PedidoItemCardapio> Update(MSG.PedidoItemCardapio model)
    {
        var PedidoItemCardapio = await _PedidoItemCardapioService.GetById(model.Id, include: false, tracking: true);
        if (PedidoItemCardapio == null)
            throw new Exception("O Item do Cardapio não existe.");

        _mapper.Map(model, PedidoItemCardapio);

        PedidoItemCardapio = await _PedidoItemCardapioService.Update(PedidoItemCardapio);

        return _mapper.Map<PedidoItemCardapio>(PedidoItemCardapio);
    }

    public async Task<PedidoItemCardapio> GetById(Guid id)
    {
        var PedidoItemCardapio = await _PedidoItemCardapioService.GetById(id, include: false, tracking: false);
        return _mapper.Map<PedidoItemCardapio>(PedidoItemCardapio);
    }

    

    public void Dispose()
    {
        _PedidoItemCardapioService.Dispose();

        GC.SuppressFinalize(this);
    }
}
