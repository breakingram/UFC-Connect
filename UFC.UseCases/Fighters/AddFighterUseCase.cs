using UFC.CoreBusiness.Exceptions;
using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.UseCases.PluginInterfaces;

namespace UFC.UseCases.Fighters;

public class AddFighterUseCase : IAddFighterUseCase
{
    private readonly IFighterRepository fighterRepository;

    public AddFighterUseCase(IFighterRepository fighterRepository)
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
                    !f.IsAlterEgo
                    && f.FirstName.Equals(fighter.FirstName, StringComparison.OrdinalIgnoreCase)
                    && f.LastName.Equals(fighter.LastName, StringComparison.OrdinalIgnoreCase)
                )
            )
            {
                throw new FighterNameAlreadyExistsException(
                    $"A fighter with the name '{fighter.GetFullName()}' already exists"
                );
            }
        }

        await fighterRepository.AddFighterAsync(fighter);
    }
}
