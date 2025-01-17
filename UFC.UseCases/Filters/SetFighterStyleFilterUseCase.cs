using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class SetFighterStyleFilterUseCase : ISetFighterStyleFilterUseCase
{
    private readonly IFighterFilterRepository fighterFilterRepository;

    public SetFighterStyleFilterUseCase(IFighterFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task ExecuteAsync(FighterStyleEnum? fighterStyle)
    {
        await this.fighterFilterRepository.SetFighterStyleFilter(fighterStyle);
    }
}
