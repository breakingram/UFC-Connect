using Microsoft.AspNetCore.Identity;

namespace UFC.WebApp.Data;

public class ApplicationUser : IdentityUser
{
    public List<UserRequestedRole> RequestedRoles { get; set; } = new List<UserRequestedRole>();
}
