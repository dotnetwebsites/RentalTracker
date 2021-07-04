using Microsoft.AspNetCore.Http;
using RentalTracker.Web.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class Rent : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RentId { get; set; }

        [Display(Name = "Tenant")]
        [Required(ErrorMessage = "Please choose Tenant")]
        public int? TenantId { get; set; }

        [ForeignKey("TenantId")]
        public TenantMaster TenantMaster { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Rent date required")]
        [Display(Name = "Rent Date")]
        public DateTime RentDate { get; set; }

        [Required(ErrorMessage = "Rent amount required")]
        [Display(Name = "Rent Amount")]
        public Double RentAmount { get; set; }

        [Display(Name = "Reading Unit")]
        public int ReadingUnit { get; set; }

        [Display(Name = "Reading Amount")]
        public Double ReadingAmount { get; set; }

        [Display(Name = "Other Excess")]
        public string OtherExcess { get; set; }

        [Display(Name = "Other Excess Amount")]
        public Double OtherAmount { get; set; }


        [Display(Name = "Remark")]
        public string Remark { get; set; }
    }
}
