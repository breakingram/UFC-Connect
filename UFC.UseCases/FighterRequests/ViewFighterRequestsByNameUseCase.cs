using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.FighterRequests.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.FighterRequests;

public class ViewFighterRequestsByNameUseCase : IViewFighterRequestsByNameUseCase
{
    private readonly IFighterRequestRepository fighterRequestRepository;

    public ViewFighterRequestsByNameUseCase(IFighterRequestRepository fighterRequestRepository)
    {
        this.fighterRequestRepository = fighterRequestRepository;
    }

    public async Task<List<FighterRequest>> ExecuteAsync(string fighterName)
    {
        return await fighterRequestRepository.GetFighterRequestsByNameAsync(fighterName);
    }
}
