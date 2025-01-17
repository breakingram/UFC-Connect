using UFC.CoreBusiness.Exceptions;
using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class UpdateFighterUseCase : IUpdateFighterUseCase
{
    private readonly IFighterRepository fighterRepository;

    public UpdateFighterUseCase(IFighterRepository fighterRepository)
    {
        this.fighterRepository = fighterRepository;
    }

    public async Task ExecuteAsync(Fighter fighter)
    {
        if (!fighter.IsAlterEgo)
        {
            var existingFighter = await fighterRepository.GetFightersByNameAsync(
                fighter.GetFullName()
            );
            if (
                existingFighter.Any(f =>
                    f.FighterId != fighter.FighterId
                    && !f.IsAlterEgo
                    && f.GetFullName()
                        .Equals(fighter.GetFullName(), StringComparison.OrdinalIgnoreCase)
                )
            )
            {
                throw new FighterNameAlreadyExistsException(
                    $"A fighter with the name '{fighter.GetFullName()}' already exists"
                );
            }
        }

        await fighterRepository.UpdateFighterAsync(fighter);
    }
}
