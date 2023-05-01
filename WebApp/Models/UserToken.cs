using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class UserToken
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }
        [ForeignKey("User")]
        [Column(Order = 2)]
        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(450)", Order = 3)]
        [Required]
        public string LoginProvider { get; set; }

        [Column(TypeName = "nvarchar(450)", Order = 4)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(1024)", Order = 5)]
        [Required]
        public string Value { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 6)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 7)]
        public DateTime? ModifiedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 8)]
        [Required]
        public DateTime ExpiresAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 9)]
        public DateTime? RevokedAt { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 10)]
        [Required]
        public string CreatedByIpAddress { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 11)]
        public string ModifiedByIpAddress { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 12)]
        public string RevokedByIpAddress { get; set; }

        [Column(TypeName = "bit", Order = 13)]
        [Required]
        [DefaultValue(false)]
        public bool IsExpired => DateTime.UtcNow >= ExpiresAt;

        [Column(TypeName = "bit", Order = 14)]
        [Required]
        [DefaultValue(false)]
        public bool IsRevoked => RevokedAt != null ? true : false;

        [Column(TypeName = "bit", Order = 15)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive => !IsExpired && !IsRevoked;

        public virtual User User { get; set; }
    }
}
