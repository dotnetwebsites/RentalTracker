using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class Country : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }

        [Display(Name = "Country Code")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter Country Code")]
        public string CountryCode { get; set; }

        [Display(Name = "Country")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter Country")]
        public string CountryName { get; set; }

        [Display(Name = "Short Name")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter Short Name")]
        public string ShortName { get; set; }

        public ICollection<State> States { get; set; }
        //public ICollection<TenantMaster> RelatedTenants { get; set; }
    }
}