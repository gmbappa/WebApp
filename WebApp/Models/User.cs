using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class User
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            Tokens = new HashSet<UserToken>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 2)]
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "nvarchar(50)", Order = 3)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Column(TypeName = "nvarchar(50)", Order = 4)]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        [Column(TypeName = "nvarchar(150)", Order = 5)]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(1024)", Order = 6)]
        public string PasswordSalt { get; set; }

        [Column(TypeName = "nvarchar(1024)", Order = 7)]
        [Required]
        public string PasswordHash { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 8)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 9)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 10)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserToken> Tokens { get; set; }
    }
}
