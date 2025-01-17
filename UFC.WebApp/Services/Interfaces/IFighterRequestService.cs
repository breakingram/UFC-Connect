using UFC.WebApp.DTOs;

namespace UFC.WebApp.Services.Interfaces;

public interface IFighterRequestService
{
    Task SetFighterRequestAsync(int fighterRequestId, FighterDto fighter);
    Task UpdateFighterRequestAsync(int fighterRequestId);
}
