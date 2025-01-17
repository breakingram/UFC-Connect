using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.FighterRequests.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.FighterRequests;

public class DeleteFighterRequestUseCase : IDeleteFighterRequestUseCase
{
    private readonly IFighterRequestRepository fighterRequestRepository;

    public DeleteFighterRequestUseCase(IFighterRequestRepository fighterRequestRepository)
    {
        this.fighterRequestRepository = fighterRequestRepository;
    }

    public async Task ExecuteAsync(FighterRequest fighterRequest)
    {
        await fighterRequestRepository.DeleteFighterAsync(fighterRequest);
    }
}
