using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IViewFightersByNameUseCase
{
    Task<List<Fighter>> ExecuteAsync(string fighterName);
}
