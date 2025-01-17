using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.FighterRequests.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.FighterRequests;

public class AddFighterRequestUseCase : IAddFighterRequestUseCase
{
    private readonly IFighterRequestRepository fighterRequestRepository;

    public AddFighterRequestUseCase(IFighterRequestRepository fighterRequestRepository)
    {
        this.fighterRequestRepository = fighterRequestRepository;
    }

    public async Task ExecuteAsync(FighterRequest fighterRequest)
    {
        await fighterRequestRepository.AddFighterRequestAsync(fighterRequest);
    }
}
