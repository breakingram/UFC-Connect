using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IViewFighterByIdUseCase
{
    Task<Fighter> ExecuteAsync(int fighterId);
}
