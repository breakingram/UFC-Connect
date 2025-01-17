using UFC.CoreBusiness;
using UFC.CoreBusiness.Filters;
using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class SetStandUpFilterUseCase : ISetStandUpFilterUseCase
{
    private readonly IFighterFilterRepository fighterFilterRepository;

    public SetStandUpFilterUseCase(IFighterFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task ExecuteAsync(FighterStandUpFilter? standUpFilters)
    {
        await this.fighterFilterRepository.SetStandUpFilter(standUpFilters);
    }
}
