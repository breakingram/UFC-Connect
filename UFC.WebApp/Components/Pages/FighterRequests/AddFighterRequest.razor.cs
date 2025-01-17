using Microsoft.AspNetCore.Components;
using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.FighterRequests.Interfaces;
using UFC.UseCases.PluginInterfaces;
using UFC.WebApp.Services.Interfaces;

namespace UFC.WebApp.Components.Pages.FighterRequests;

public partial class AddFighterRequest : ComponentBase
{
    [Inject]
    public required IAuthService AuthService { get; set; }

    [Inject]
    public required IViewFighterRequestByIdUseCase ViewFighterRequestByIdUseCase { get; set; }

    [Inject]
    public required IAddFighterRequestUseCase AddFighterRequestUseCase { get; set; }

    [Inject]
    public required IFighterRequestRepository FighterRequestRepository { get; set; }

    [Inject]
    public required NavigationManager NavigationManager { get; set; }

    private FighterRequest FighterRequest = new FighterRequest();

    private string? ValidationMessage;

    private async Task Save()
    {
        ValidationMessage = null;

        var fullName = $"{FighterRequest.FirstName} {FighterRequest.LastName}";
        var nameExists = await FighterRequestRepository.IsNameExistsAsync(
            fullName,
            FighterRequest.Id
        );
        if (nameExists)
        {
            ValidationMessage = $"The name {fullName} already exists.";
            return;
        }

        var currentDate = DateTime.UtcNow;
        FighterRequest.DateCreated = currentDate;

        var userId = await AuthService.GetUserIdAsync();
        if (!string.IsNullOrWhiteSpace(userId))
            FighterRequest.AddByUserId = userId;

        await AddFighterRequestUseCase.ExecuteAsync(FighterRequest);
        NavigationManager.NavigateTo("/fighterrequests");
    }

    private void HandleInvalidSubmit() { }
}
