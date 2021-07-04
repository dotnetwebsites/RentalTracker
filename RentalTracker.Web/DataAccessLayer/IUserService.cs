using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public interface IUserService
    {
        Task<UserIdentityResult> CreateInitialUser();

        Task AddRoleToSpecificUser(ApplicationUser user, string RoleName);
    }
}
