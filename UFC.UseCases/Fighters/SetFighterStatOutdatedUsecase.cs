using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class SetFighterStatOutdatedUsecase : ISetFighterStatOutdatedUsecase
{
    private readonly IFighterRepository fighterRepository;

    public SetFighterStatOutdatedUsecase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task ExecuteAsync(Fighter fighter, string userId)
    {
        await fighterRepository.SetOutdatedFighterStatsAsync(fighter, userId);
    }
}
