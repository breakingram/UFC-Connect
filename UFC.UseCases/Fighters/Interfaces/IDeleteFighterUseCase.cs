using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IDeleteFighterUseCase
{
    Task ExecuteAsync(Fighter fighter);
}
