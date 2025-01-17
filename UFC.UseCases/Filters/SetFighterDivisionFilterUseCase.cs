using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class SetFighterDivisionFilterUseCase : ISetFighterDivisionFilterUseCase
{
    private readonly IFighterFilterRepository fighterFilterRepository;

    public SetFighterDivisionFilterUseCase(IFighterFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task ExecuteAsync(DivisionEnum? division)
    {
        await this.fighterFilterRepository.SetFighterDivisionFilter(division);
    }
}
