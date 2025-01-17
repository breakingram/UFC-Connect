using UFC.CoreBusiness.FighterRequestModel;

namespace UFC.UseCases.FighterRequests.Interfaces;

public interface IViewFighterRequestByIdUseCase
{
    Task<FighterRequest> ExecuteAsync(int fighterRequestId);
}
