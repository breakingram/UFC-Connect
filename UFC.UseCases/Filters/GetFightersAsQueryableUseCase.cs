using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class GetFightersAsQueryableUseCase : IGetFightersAsQueryableUseCase
{
    private readonly IFighterFilterRepository fighterFilterRepository;

    public GetFightersAsQueryableUseCase(IFighterFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task<IQueryable<Fighter>> ExecuteAsync()
    {
        return await this.fighterFilterRepository.GetFightersAsQueryable();
    }
}
