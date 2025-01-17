using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IAddAlterEgoFighterUseCase
{
    Task ExecuteAsync(int baseFighterId, Fighter alterEgo);
}
