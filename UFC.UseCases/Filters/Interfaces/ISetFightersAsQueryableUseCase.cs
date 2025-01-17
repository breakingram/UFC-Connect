using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Filters.Interfaces;

public interface ISetFightersAsQueryableUseCase
{
    Task ExecuteAsync(IQueryable<Fighter> query);
}
