using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Role
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 2)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text", Order = 3)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 4)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 5)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 6)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
