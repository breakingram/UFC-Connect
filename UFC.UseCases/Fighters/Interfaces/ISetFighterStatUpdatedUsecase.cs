using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface ISetFighterStatUpdatedUsecase
{
    Task ExecuteAsync(Fighter fighter);
}
