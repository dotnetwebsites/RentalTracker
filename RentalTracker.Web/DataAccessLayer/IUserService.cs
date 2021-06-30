using Microsoft.AspNetCore.Identity;
using RentalTracker.Web.Areas.Identity.Data;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public interface IUserService
    {
        Task<IdentityResult> CreateInitialUser();

        Task AddRoleToSpecificUser(ApplicationUser user, string RoleName);
    }
}
