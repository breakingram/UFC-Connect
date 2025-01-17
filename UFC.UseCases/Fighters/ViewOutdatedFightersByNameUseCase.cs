using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class ViewOutdatedFightersByNameUseCase : IViewOutdatedFightersByNameUseCase
{
    private readonly IFighterRepository fighterRepository;

    public ViewOutdatedFightersByNameUseCase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task<List<Fighter>> ExecuteAsync(string fighterName)
    {
        return await fighterRepository.GetOutdatedFightersAsync(fighterName);
    }
}
