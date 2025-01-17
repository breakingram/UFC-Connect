using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class ViewFightersByNameUseCase : IViewFightersByNameUseCase
{
    private readonly IFighterRepository fighterRepository;

    public ViewFightersByNameUseCase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task<List<Fighter>> ExecuteAsync(string fighterName)
    {
        return await fighterRepository.GetFightersByNameAsync(fighterName);
    }
}
