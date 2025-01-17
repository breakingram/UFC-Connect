using UFC.CoreBusiness.FighterModel;

namespace UFC.UseCases.Fighters.Interfaces;

public interface IViewBaseFightersUseCase
{
    Task<List<Fighter>> ExecuteAsync(string searchQuery = "", int? limit = null);
}
