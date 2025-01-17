using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class SetFighterStatUpdatedUsecase : ISetFighterStatUpdatedUsecase
{
    private readonly IFighterRepository fighterRepository;

    public SetFighterStatUpdatedUsecase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task ExecuteAsync(Fighter fighter)
    {
        await fighterRepository.SetUpdatedFighterStatsAsync(fighter);
    }
}
