using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Filters.Interfaces;

public interface ISetFighterDivisionFilterUseCase
{
    Task ExecuteAsync(DivisionEnum? division);
}
