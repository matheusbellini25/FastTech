using FastTech.Domain.Entities;
using FastTech.Domain.Interfaces;
using FastTech.Domain.Interfaces.Infrastructure;

namespace FastTech.Domain.Services;

public class StateDDDService(IStateDDDRepository repository, UserData userData) : IStateDDDService
{
    protected readonly IStateDDDRepository _repository = repository;
    protected readonly UserData _userData = userData;

    public async Task<StateDDD> GetByDDDAsync(int ddd)
        => await _repository.GetByDDDAsync(ddd);

    public async Task<IEnumerable<StateDDD>> GetByRegionAsync(string state)
        => await _repository.GetByRegionAsync(state);

    public async Task<IEnumerable<StateDDD>> GetByStateAsync(string state)
        => await _repository.GetByStateAsync(state);
}