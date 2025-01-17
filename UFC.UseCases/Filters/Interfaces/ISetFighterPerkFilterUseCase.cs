using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Filters.Interfaces;

public interface ISetFighterPerkFilterUseCase
{
    Task ExecuteAsync(PerksEnum? perk);
}
