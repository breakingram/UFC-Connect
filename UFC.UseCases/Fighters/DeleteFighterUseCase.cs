using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class DeleteFighterUseCase : IDeleteFighterUseCase
{
    private readonly IFighterRepository fighterRepository;

    public DeleteFighterUseCase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task ExecuteAsync(Fighter fighter)
    {
        await fighterRepository.DeleteFighterAsync(fighter);
    }
}
