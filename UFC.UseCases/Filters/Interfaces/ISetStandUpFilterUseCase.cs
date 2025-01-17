using UFC.CoreBusiness.Filters;

namespace UFC.UseCases.Filters.Interfaces;

public interface ISetStandUpFilterUseCase
{
    Task ExecuteAsync(FighterStandUpFilter? standUpFilters);
}
