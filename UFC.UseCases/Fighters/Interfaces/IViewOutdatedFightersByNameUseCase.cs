using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IViewOutdatedFightersByNameUseCase
{
    Task<List<Fighter>> ExecuteAsync(string fighterName);
}
