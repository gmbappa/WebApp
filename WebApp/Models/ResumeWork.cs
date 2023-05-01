using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class ResumeWork
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
        public string Designation { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 6)]
        [Required]
        public string CompanyName { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 7)]
        public string CompanyLink { get; set; }

        [Column(TypeName = "text", Order = 8)]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(250)", Order = 9)]
        public string Location { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 10)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 11)]
        public DateTime? EndDate { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 12)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 13)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 14)]
        [Required]
        [DefaultValue(false)]
        public bool IsCurrent { get; set; }

        [Column(TypeName = "bit", Order = 15)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
