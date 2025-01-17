using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Filters.Interfaces;

public interface IGetFightersAsQueryableUseCase
{
    Task<IQueryable<Fighter>> ExecuteAsync();
}
