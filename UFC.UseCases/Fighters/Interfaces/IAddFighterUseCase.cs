using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IAddFighterUseCase
{
    Task ExecuteAsync(Fighter fighter);
}
