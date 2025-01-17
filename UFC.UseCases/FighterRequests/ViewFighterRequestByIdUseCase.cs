using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.FighterRequests.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.FighterRequests;

public class ViewFighterRequestByIdUseCase : IViewFighterRequestByIdUseCase
{
    private readonly IFighterRequestRepository fighterRequestRepository;

    public ViewFighterRequestByIdUseCase(IFighterRequestRepository fighterRequestRepository)
    {
        this.fighterRequestRepository = fighterRequestRepository;
    }

    public async Task<FighterRequest> ExecuteAsync(int fighterRequestId)
    {
        return await fighterRequestRepository.GetFighterRequestByIdAsync(fighterRequestId);
    }
}
