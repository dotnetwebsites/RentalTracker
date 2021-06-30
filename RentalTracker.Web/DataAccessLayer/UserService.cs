using Microsoft.AspNetCore.Identity;
using RentalTracker.Web.Areas.Identity.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserService(UserManager<ApplicationUser> userManager,
                            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> CreateInitialUser()
        {
            var user = new ApplicationUser
            {
                UserName = "admin",
                Email = "kpljain21@gmail.com",
                EmailConfirmed = true
            };

            var u = _userManager.Users.Any(p => p.UserName == "admin");

            if (u == true)
            {
                return null;
            }

            var result = await _userManager.CreateAsync(user, "India@123");
            if (result.Succeeded)
            {
                await AddRoleToSpecificUser(user, "superadmin");
                await AddRoleToSpecificUser(user, "admin");
            }

            return result;
        }

        public async Task AddRoleToSpecificUser(ApplicationUser user, string RoleName)
        {
            IdentityRole identityRole = new IdentityRole
            {
                Name = RoleName
            };

            if (!(await _roleManager.RoleExistsAsync(RoleName)))
            {
                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    if (!(await _userManager.IsInRoleAsync(user, RoleName)))
                        await _userManager.AddToRoleAsync(user, RoleName);
                }
            }
            else
            {
                if (!(await _userManager.IsInRoleAsync(user, RoleName)))
                    await _userManager.AddToRoleAsync(user, RoleName);
            }

        }

    }
}
