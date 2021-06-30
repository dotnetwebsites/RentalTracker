using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentalTracker.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IdentityResult> Index()
        {
            var result = await _userService.CreateInitialUser();
            if (result != null)
            {
                return result;
            }

            return null;
        }
    }
}
