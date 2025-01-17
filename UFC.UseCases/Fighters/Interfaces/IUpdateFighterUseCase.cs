using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IUpdateFighterUseCase
{
    Task ExecuteAsync(Fighter fighter);
}
