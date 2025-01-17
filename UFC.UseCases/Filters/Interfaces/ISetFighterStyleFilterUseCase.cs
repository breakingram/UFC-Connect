using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Filters.Interfaces;

public interface ISetFighterStyleFilterUseCase
{
    Task ExecuteAsync(FighterStyleEnum? fighterStyle);
}
