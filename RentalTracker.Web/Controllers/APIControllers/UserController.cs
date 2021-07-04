using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentalTracker.Web.DAL;
using RentalTracker.Web.Models;
using System.Threading.Tasks;

namespace RentalTracker.Web.Controllers.APIControllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [Route("api/user/createadminuser")]
        public async Task<UserIdentityResult> Index()
        {
            var result = await _userService.CreateInitialUser();            
            return result;
        }
    }
}
