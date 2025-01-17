using UFC.CoreBusiness.Exceptions;
using UFC.CoreBusiness.FighterModel;
using UFC.WebApp.DTOs;
using UFC.WebApp.Services.Interfaces;

namespace UFC.WebApp.Services;

public class FighterValidationService : IFighterValidationService
{
    private readonly IFighterService _fighterService;

    public FighterValidationService(IFighterService fighterService)
    {
        _fighterService = fighterService;
    }

    public async Task ValidateFighterFullNameAsync(FighterDto fighterDto)
    {
        if (!fighterDto.IsAlterEgo)
        {
            var existingFighters = await _fighterService.GetFightersByNameAsync(
                $"{fighterDto.FirstName} {fighterDto.LastName}"
            );
            if (
                existingFighters.Any(f =>
                    !f.IsAlterEgo
                    && f.FirstName.Equals(
                        fighterDto.FirstName,
                        StringComparison.OrdinalIgnoreCase
                    )
                    && f.LastName.Equals(
                        fighterDto.LastName,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
            )
            {
                throw new FighterNameAlreadyExistsException(
                    $"A fighter with the name '{fighterDto.FirstName} {fighterDto.LastName}' already exists"
                );
            }
        }
    }

    public async Task ValidateFighterAlterEgoNameAsync(
        Fighter? baseFighter,
        FighterDto fighterDto
    )
    {
        if (baseFighter != null && fighterDto.IsAlterEgo)
        {
            var basefighter = await _fighterService.GetFighterByIdAsync(baseFighter.FighterId);
            var baseFighterEgoName = basefighter.EgoName;
            var newAlterEgoName = fighterDto.EgoName;
            if (baseFighterEgoName == newAlterEgoName)
            {
                throw new FighterAlterEgoNameException(
                    $"Alter Egos must have different Ego name from base fighter"
                );
            }
        }
    }
}
