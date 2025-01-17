using Microsoft.AspNetCore.Components;
using UFC.CoreBusiness.FighterModel;

namespace UFC.WebApp.Components.Controls.FighterDetailComponents;

public partial class FighterGrapplingDetailComponent : ComponentBase
{
    [Parameter]
    public required Fighter Fighter { get; set; }
}
