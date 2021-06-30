using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.Models
{
    public abstract class BaseEntity
    {
        [MaxLength(100)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;


        [MaxLength(100)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [NotMapped]
        public string ReturnUrl { get; set; }

        [NotMapped]
        public string LogMessage { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
