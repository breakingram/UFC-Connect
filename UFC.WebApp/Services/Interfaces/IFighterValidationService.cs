using UFC.CoreBusiness.FighterModel;
using UFC.WebApp.DTOs;

namespace UFC.WebApp.Services.Interfaces;

public interface IFighterValidationService
{
    Task ValidateFighterFullNameAsync(FighterDto fighterDto);
    Task ValidateFighterAlterEgoNameAsync(Fighter? baseFighter, FighterDto fighterDto);
}
