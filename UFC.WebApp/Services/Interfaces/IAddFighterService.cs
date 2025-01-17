using UFC.WebApp.DTOs;

namespace UFC.WebApp.Services.Interfaces;

public interface IAddFighterService
{
    Task AddFighterAsync(FighterDto dto);
}