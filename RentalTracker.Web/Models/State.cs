using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class State : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateId { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please choose Country")]
        public int? CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        [Display(Name = "State Code")]
        [MaxLength(100)]        
        [Required(ErrorMessage = "Please enter State Code")]
        public string StateCode { get; set; }

        [Display(Name = "State")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter State")]
        public string StateName { get; set; }

        [Display(Name = "Short Name")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter Short Name")]
        public string ShortName { get; set; }

        public ICollection<City> Cities { get; set; }
        //public ICollection<TenantMaster> RelatedTenants { get; set; }
    }

    public class StateView : State
    {
        [Display(Name = "Coutry")]
        public string CoutryName { get; set; }
    }
}