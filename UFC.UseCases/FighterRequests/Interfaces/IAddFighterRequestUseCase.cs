using UFC.CoreBusiness.FighterRequestModel;

namespace UFC.UseCases.FighterRequests.Interfaces;

public interface IAddFighterRequestUseCase
{
    Task ExecuteAsync(FighterRequest fighterRequest);
}
