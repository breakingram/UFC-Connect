using Microsoft.AspNetCore.Components;
using UFC.CoreBusiness.FighterModel;
using UFC.CoreBusiness.FighterRequestModel;
using UFC.UseCases.PluginInterfaces;
using UFC.WebApp.Extensions;

namespace UFC.WebApp.Components.Controls.FiltersComponents;

public partial class FightersStatusFilterComponent : ComponentBase
{
    [Inject]
    public required IFighterStatusFilterRepository FighterStatusFilterRepository { get; set; }

    public FighterUpdateStatusEnum? selectedStatus { get; set; }

    [Parameter]
    public EventCallback RefreshGrid { get; set; }

    private string GetButtonLabel()
    {
        return selectedStatus.HasValue ? selectedStatus.Value.GetDisplayName() : "Status Filter";
    }

    private async Task Reset()
    {
        selectedStatus = null;
        await FighterStatusFilterRepository.ResetQuery();
        await OnRefreshGrid();
    }

    private async Task OnSelectStatus(FighterUpdateStatusEnum? status)
    {
        selectedStatus = status;
        await FighterStatusFilterRepository.SetFighterStatusFilter(selectedStatus);
        await OnRefreshGrid();
    }

    private async Task OnRefreshGrid()
    {
        await RefreshGrid.InvokeAsync();
    }
}
