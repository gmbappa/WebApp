using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class ResumeTestimony
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
        public int? SerialNo { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 4)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 5)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 6)]
        [Required]
        public string Designation { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 7)]
        [Required]
        public string Profession { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 8)]
        public string Company { get; set; }

        [Column(TypeName = "text", Order = 9)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 10)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 11)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 12)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
