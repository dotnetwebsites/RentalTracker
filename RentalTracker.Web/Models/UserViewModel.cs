using RentalTracker.Web.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.Models
{
    public class UserViewModel
    {

    }

    public class UserIdentityResult : APIResult
    {
        public ApplicationUser CreatedUser { get; set; }
    }
}
