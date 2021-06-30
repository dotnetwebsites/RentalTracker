using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentalTracker.Web.Models
{
    public class AspNetUserRoleMenu
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [MaxLength(900)]
        public string RoleId { get; set; }

        public int MenuId { get; set; }

    }
}