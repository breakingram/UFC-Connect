using AutoMapper;
using UFC.CoreBusiness.FighterModel;
using UFC.UseCases.Fighters.Interfaces;
using UFC.WebApp.DTOs;
using UFC.WebApp.Services.Interfaces;

namespace UFC.WebApp.Services;

public class FighterService : IFighterService
{
    private readonly IAddFighterUseCase _addFighterUseCase;
    private readonly IAddAlterEgoFighterUseCase _addAlterEgoFighterUseCase;
    private readonly IViewFighterByIdUseCase _viewFighterByIdUseCase;
    private readonly IViewBaseFightersUseCase _viewBaseFightersUseCase;
    private readonly IViewFightersByNameUseCase _viewFightersByNameUseCase;
    private readonly IAuthService _authService;
    private readonly IMapper _mapper;

    public FighterService(
        IAddFighterUseCase addFighterUseCase,
        IAddAlterEgoFighterUseCase addAlterEgoFighterUseCase,
        IViewFighterByIdUseCase viewFighterByIdUseCase,
        IViewBaseFightersUseCase viewBaseFightersUseCase,
        IViewFightersByNameUseCase viewFightersByNameUseCase,
        IAuthService authService,
        IMapper mapper
    )
    {
        _addFighterUseCase = addFighterUseCase;
        _addAlterEgoFighterUseCase = addAlterEgoFighterUseCase;
        _viewFighterByIdUseCase = viewFighterByIdUseCase;
        _viewBaseFightersUseCase = viewBaseFightersUseCase;
        _viewFightersByNameUseCase = viewFightersByNameUseCase;
        _authService = authService;
        _mapper = mapper;
    }

    public async Task AddFighterAsync(FighterDto fighterDto)
    {
        var fighter = _mapper.Map<Fighter>(fighterDto);
        if (fighter.IsAlterEgo && fighter.BaseFighterId.HasValue)
        {
            await _addAlterEgoFighterUseCase.ExecuteAsync(fighter.BaseFighterId.Value, fighter);
        }
        else
        {
            await _addFighterUseCase.ExecuteAsync(fighter);
        }
    }

    public async Task<List<FighterDto>> GetBaseFightersAsync()
    {
        var baseFighters = await _viewBaseFightersUseCase.ExecuteAsync("");
        return _mapper.Map<List<FighterDto>>(baseFighters);
    }

    public async Task<FighterDto> GetFighterByIdAsync(int fighterId)
    {
        var fighter = await _viewFighterByIdUseCase.ExecuteAsync(fighterId);
        return _mapper.Map<FighterDto>(fighter);
    }

    public async Task<List<FighterDto>> GetFightersByNameAsync(string name)
    {
        var fighters = await _viewFightersByNameUseCase.ExecuteAsync(name);
        return _mapper.Map<List<FighterDto>>(fighters);
    }

    public async Task SetUserIdToFighterAsync(FighterDto fighter)
    {
        var userId = await _authService.GetUserIdAsync();
        if (userId != null)
            fighter.AddedByUserId = userId;
    }
}
