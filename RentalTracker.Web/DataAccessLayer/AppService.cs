using Microsoft.AspNetCore.Identity;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public class AppService : IAppService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _repository;

        public AppService(UserManager<ApplicationUser> userManager,
                            RoleManager<IdentityRole> roleManager,
                            ApplicationDbContext repository)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _repository = repository;
        }

        public bool IsAppAuthorized()
        {
            return _repository.MailLibraries.Any(p => p.System);
        }

        public APIResult IsApiAuthorized()
        {
            APIResult res = new APIResult();
            if (_repository.MailLibraries.Any(p => p.System))
                res.Message = "Not Authorize";

            return res;
        }
    }
}
