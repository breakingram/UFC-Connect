using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class AddAlterEgoFighterUseCase : IAddAlterEgoFighterUseCase
{
    private readonly IFighterRepository fighterRepository;

    public AddAlterEgoFighterUseCase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task ExecuteAsync(int baseFighterId, Fighter alterEgo)
    {
        await fighterRepository.AddAlterEgoAsync(baseFighterId, alterEgo);
    }
}
