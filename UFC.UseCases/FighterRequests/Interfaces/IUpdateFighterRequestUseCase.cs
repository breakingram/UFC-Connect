using UFC.CoreBusiness.FighterRequestModel;

namespace UFC.UseCases.FighterRequests.Interfaces;

public interface IUpdateFighterRequestUseCase
{
    Task ExecuteAsync(FighterRequest fighterRequest);
}
