using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace UFC.WebApp.Components.Common;

public partial class NotAuthorizedContent : ComponentBase
{
    [CascadingParameter]
    private Task<AuthenticationState>? AuthenticationStateTask { get; set; }

    private bool IsAuthenticated = false;

    protected override async Task OnInitializedAsync()
    {
        if (AuthenticationStateTask != null)
        {
            var user = (await AuthenticationStateTask).User;
            IsAuthenticated = user?.Identity?.IsAuthenticated ?? false;
        }
    }
}
