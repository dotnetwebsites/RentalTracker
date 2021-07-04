using Microsoft.AspNetCore.Http;
using RentalTracker.Web.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class TenantMaster : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TenantId { get; set; }

        //public virtual ICollection<Country> TenantRelatedCountries { get; set; }
        //public virtual ICollection<State> TenantRelatedStates { get; set; }
        //public virtual ICollection<City> TenantRelatedCities { get; set; }

        [Required(ErrorMessage = "Please enter house rent")]
        [Display(Name = "Monthly House Rent")]
        public int HouseRent { get; set; }

        [Required(ErrorMessage = "Please enter reading per unit")]
        [Display(Name = "Meter Reading Per Unit")]
        public int ReadingPerUnit { get; set; }

        [Required(ErrorMessage = "Please enter starting reading unit")]
        [Display(Name = "Starting Reading Unit")]
        public int StartReading { get; set; }

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

        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [MaxLength(100)]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }

        [MaxLength(100)]
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }

        [MaxLength(10)]
        [Display(Name = "Mobile No")]
        [Required(ErrorMessage = "Please enter contact no")]
        public string ContactNo { get; set; }

        [MaxLength(12)]
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

        //[Display(Name = "Country")]
        //[Required(ErrorMessage = "Please choose Country")]
        //public int? CountryId { get; set; }

        //[ForeignKey("CountryId")]
        //public Country Country { get; set; }

        //[Display(Name = "State")]
        //[Required(ErrorMessage = "Please choose State")]
        //public int? StateId { get; set; }

        //[ForeignKey("CountryId")]
        //public State State { get; set; }

        [NotMapped]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please choose Country")]
        public int? CountryId { get; set; }

        [NotMapped]
        [Display(Name = "State")]
        [Required(ErrorMessage = "Please choose State")]
        public int? StateId { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please choose City")]
        public int? CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }


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
        [Display(Name = "Upload Doc")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png", ".pdf" })]
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

        public ICollection<Rent> Rents { get; set; }
    }
}
