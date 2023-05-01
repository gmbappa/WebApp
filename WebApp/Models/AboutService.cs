using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class AboutService
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

        [Column(TypeName = "int", Order = 4)]
        [DefaultValue(1)]
        public int? Rating { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 5)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 6)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text", Order = 7)]
        public string Description { get; set; }

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

        public virtual Profile Profile { get; set; }
    }
}
