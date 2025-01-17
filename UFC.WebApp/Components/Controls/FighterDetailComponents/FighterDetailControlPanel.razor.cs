using Microsoft.AspNetCore.Components;
using UFC.CoreBusiness.FighterModel;

namespace UFC.WebApp.Components.Controls.FighterDetailComponents;

public partial class FighterDetailControlPanel : ComponentBase
{
    [Parameter]
    public Fighter? Fighter { get; set; }

    [Parameter]
    public EventCallback OnRefresh { get; set; }

    private void Refresh()
    {
        OnRefresh.InvokeAsync();
    }
}
