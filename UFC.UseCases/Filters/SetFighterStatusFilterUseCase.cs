using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.Filters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Filters;

public class SetFighterStatusFilterUseCase : ISetFighterStatusFilterUseCase
{
    private readonly IFighterStatusFilterRepository fighterFilterRepository;

    public SetFighterStatusFilterUseCase(IFighterStatusFilterRepository fighterFilterRepository)
    {
        this.fighterFilterRepository = fighterFilterRepository;
    }

    public async Task ExecuteAsync(FighterUpdateStatusEnum? status)
    {
        await this.fighterFilterRepository.SetFighterStatusFilter(status);
    }
}
