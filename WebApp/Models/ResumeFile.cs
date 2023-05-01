using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class ResumeFile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [ForeignKey("Profile")]
        [Column(Order = 2)]
        [Required]
        public int ProfileId { get; set; }

        [Column(TypeName = "int", Order = 3)]
        [Required]
        public int Version { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 4)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 5)]
        public string FileUrl { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 6)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 7)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 8)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
