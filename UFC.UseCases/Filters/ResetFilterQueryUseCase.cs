using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class ResetFilterQueryUseCase : IResetFilterQueryUseCase
{
    private readonly IFighterFilterRepository fighterFilterRepository;

    public ResetFilterQueryUseCase(IFighterFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task ExecuteAsync()
    {
        await this.fighterFilterRepository.ResetQuery();
    }
}
