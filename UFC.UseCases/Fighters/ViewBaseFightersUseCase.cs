using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class ViewBaseFightersUseCase : IViewBaseFightersUseCase
{
    private readonly IFighterRepository fighterRepository;

    public ViewBaseFightersUseCase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task<List<Fighter>> ExecuteAsync(string searchQuery = "", int? limit = null)
    {
        return await fighterRepository.GetBaseFightersAsync(searchQuery, limit);
    }
}
