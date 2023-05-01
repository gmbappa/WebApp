using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [ForeignKey("User")]
        [Column(Order = 2)]
        [Required]
        public int UserId { get; set; }

        [ForeignKey("Role")]
        [Column(Order = 3)]
        [Required]
        public int RoleId { get; set; }

        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
