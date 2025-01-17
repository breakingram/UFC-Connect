using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class SetFightersAsQueryableUseCase : ISetFightersAsQueryableUseCase
{
    private readonly IFighterFilterRepository fighterFilterRepository;

    public SetFightersAsQueryableUseCase(IFighterFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task ExecuteAsync(IQueryable<Fighter> query)
    {
        await this.fighterFilterRepository.SetFightersAsQueryable(query);
    }
}
