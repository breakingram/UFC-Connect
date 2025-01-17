using System.ComponentModel.DataAnnotations;

namespace UFC.CoreBusiness.FighterRequestModel;

public enum FighterUpdateStatusEnum
{
    [Display(Name = "Need To Be Updated")]
    NeedToBeUpdated,

    [Display(Name = "Need To Be Added")]
    NeedToBeAdded,
}
