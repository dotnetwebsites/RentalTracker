using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class City : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please choose State")]
        public int? StateId { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }

        [Display(Name = "City Code")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter City Code")]
        public string CityCode { get; set; }

        [Display(Name = "City")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter City")]
        public string CityName { get; set; }

        [Display(Name = "Short Name")]
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter Short Name")]
        public string ShortName { get; set; }        
    }

    public class CityView : City
    {
        [Display(Name = "State")]
        public string StateName { get; set; }
    }
}