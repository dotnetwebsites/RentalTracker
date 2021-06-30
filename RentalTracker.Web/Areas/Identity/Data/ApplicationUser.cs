using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RentalTracker.Web.Utilities;

namespace RentalTracker.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "Profile Image")]
        public string ProfileImage { get; set; }

        [NotMapped]
        [Display(Name = "Profile Image")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile Avatar { get; set; }

        [NotMapped]
        public IPAddress IPAddress { get; set; }

        [NotMapped]
        public Act Activity { get; set; }
    }
}
