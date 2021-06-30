using Microsoft.AspNetCore.Http;
using RentalTracker.Web.Utilities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class TenantMaster : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter house rent")]
        [Display(Name = "Monthly House Rent")]
        public int HouseRent { get; set; }

        [Required(ErrorMessage = "Please enter reading per unit")]
        [Display(Name = "Meter Reading Per Unit")]
        public int ReadingPerUnit { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Rent start date required")]
        [Display(Name = "Rent Start Date")]
        public DateTime RentStartOn { get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        [MaxLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(100)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [MaxLength(100)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [MaxLength(100)]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }

        [MaxLength(100)]
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }

        [MaxLength(100)]
        [Display(Name = "Contact No")]
        [Required(ErrorMessage = "Please enter contact no")]
        public string ContactNo { get; set; }

        [MaxLength(100)]
        [Display(Name = "Alternate No")]
        public string AlternateNo { get; set; }

        [Required(ErrorMessage = "Select id proof type")]
        [MaxLength(200)]
        [Display(Name = "ID Proof Type")]
        public string IDType { get; set; }

        [Required(ErrorMessage = "Please enter ID card no")]
        [MaxLength(100)]
        [Display(Name = "ID Card No")]
        public string IDCardNo { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Previous Address")]
        [Required(ErrorMessage = "Please enter address")]
        public string PreviousAddress { get; set; }

        [MaxLength(200)]
        [Display(Name = "City")]
        [Required(ErrorMessage = "Please select city")]
        public string City { get; set; }

        [Display(Name = "Pincode")]
        [Required(ErrorMessage = "Please enter pincode")]
        public int Pincode { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Profile Image")]
        public string ProfileImageUrl { get; set; }

        [NotMapped]
        [Display(Name = "Profile Image")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile ProfileImage { get; set; }

        [MaxLength(500)]
        [Display(Name = "Profile Image")]
        public string DocUrl { get; set; }

        [NotMapped]
        [Display(Name = "Profile Image")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        public IFormFile UploadDoc { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                if (MiddleName != null)
                    return FirstName + " " + MiddleName + " " + LastName;
                else
                    return FirstName + " " + LastName;
            }
        }

    }
}
