using UFC.CoreBusiness.FighterRequestModel;

namespace UFC.UseCases.Filters.Interfaces
{
    public interface ISetFighterStatusFilterUseCase
    {
        Task ExecuteAsync(FighterUpdateStatusEnum? status);
    }
}
