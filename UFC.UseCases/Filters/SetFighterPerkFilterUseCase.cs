using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class SetFighterPerkFilterUseCase : ISetFighterPerkFilterUseCase
{
    private readonly IFighterFilterRepository fighterFilterRepository;

    public SetFighterPerkFilterUseCase(IFighterFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task ExecuteAsync(PerksEnum? perk)
    {
        await this.fighterFilterRepository.SetFighterPerkFilter(perk);
    }
}
