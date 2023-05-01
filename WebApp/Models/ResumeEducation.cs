using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class ResumeEducation
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
        public string InstituitionName { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 6)]
        public string InstituitionLink { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 7)]
        [Required]
        public string Degree { get; set; }

        [Column(TypeName = "text", Order = 8)]
        public string Description { get; set; }

        [Column(TypeName = "float", Order = 9)]
        public double? Grade { get; set; }

        [Column(TypeName = "nvarchar(250)", Order = 10)]
        public string Activities { get; set; }

        [Column(TypeName = "nvarchar(250)", Order = 11)]
        public string Location { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 12)]
        public DateTime? StartAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 13)]
        public DateTime? EndAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 14)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 15)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 16)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
