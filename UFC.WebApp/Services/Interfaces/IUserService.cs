using Microsoft.AspNetCore.Identity;
using UFC.WebApp.Data;

namespace UFC.WebApp.Services.Interfaces;

public interface IUserService
{
    Task<ApplicationUser> GetUserByIdAsync(string userId);
    Task<List<string>> GetUserRolesAsync(ApplicationUser user);
    Task<IdentityResult> AddToRoleAsync(ApplicationUser user, string role);
    Task<IdentityResult> RemoveFromRoleAsync(ApplicationUser user, string role);
}
