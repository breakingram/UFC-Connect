using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class ViewFighterByIdUseCase : IViewFighterByIdUseCase
{
    private readonly IFighterRepository fighterRepository;

    public ViewFighterByIdUseCase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task<Fighter> ExecuteAsync(int fighterId)
    {
        return await fighterRepository.GetFighterByIdAsync(fighterId);
    }
}
