using Microsoft.AspNetCore.Components;
using UFC.WebApp.Utilities;

namespace UFC.WebApp.Components.Pages;

public partial class Testing : ComponentBase
{
    protected override async Task OnInitializedAsync() { }

    private void Clear()
    {
        DeveloperUtilities.ClearLogs();
    }
}
