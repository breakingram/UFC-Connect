using UFC.CoreBusiness.FighterRequestModel;

namespace UFC.UseCases.FighterRequests.Interfaces;

public interface IDeleteFighterRequestUseCase
{
    Task ExecuteAsync(FighterRequest fighterRequest);
}
