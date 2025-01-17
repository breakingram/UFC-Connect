using Microsoft.AspNetCore.Components;
using UFC.WebApp.Services;

namespace UFC.WebApp.Components.Common;

public partial class LoadingIndicator : ComponentBase
{
    [Inject]
    public LoadingService LoadingService { get; set; }

    protected override void OnInitialized()
    {
        if (LoadingService != null)
        {
            LoadingService.OnRefresh += Refresh;
        }
    }

    public void Refresh()
    {
        System.Console.WriteLine();
        StateHasChanged();
    }
}
