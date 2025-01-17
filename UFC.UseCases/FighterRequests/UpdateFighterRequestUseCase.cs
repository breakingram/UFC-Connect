using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.FighterRequests.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.FighterRequests;

public class UpdateFighterRequestUseCase : IUpdateFighterRequestUseCase
{
    private readonly IFighterRequestRepository fighterRequestRepository;

    public UpdateFighterRequestUseCase(IFighterRequestRepository fighterRequestRepository)
    {
        this.fighterRequestRepository = fighterRequestRepository;
    }

    public async Task ExecuteAsync(FighterRequest fighterRequest)
    {
        await fighterRequestRepository.UpdateFighterRequestAsync(fighterRequest);
    }
}
