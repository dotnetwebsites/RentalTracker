using Microsoft.AspNetCore.Http;
using RentalTracker.Web.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class MeterMaster : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MeterId { get; set; }

        public string MeterCode { get; set; }

        //[Display(Name = "Reading Unit")]
        //public int ReadingUnit { get; set; }

        //[Display(Name = "Reading Amount")]
        //public Double ReadingAmount { get; set; }

        [Display(Name = "Remark")]
        public string Remark { get; set; }
    }
}
