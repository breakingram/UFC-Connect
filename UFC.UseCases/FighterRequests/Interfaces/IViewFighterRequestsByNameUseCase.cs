using UFC.CoreBusiness.FighterRequestModel;

namespace UFC.UseCases.FighterRequests.Interfaces;

public interface IViewFighterRequestsByNameUseCase
{
    Task<List<FighterRequest>> ExecuteAsync(string fighterName);
}
