using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface ISetFighterStatOutdatedUsecase
{
    Task ExecuteAsync(Fighter fighter, string userId);
}
