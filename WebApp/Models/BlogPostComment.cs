using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class BlogPostComment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [ForeignKey("BlogPost")]
        [Column(Order = 2)]
        [Required]
        public int PostId { get; set; }

        [Column(TypeName = "int", Order = 3)]
        public int? ParentId { get; set; }

        [Column(TypeName = "int", Order = 4)]
        public int? NodeDepth { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 5)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 6)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Column(TypeName = "nvarchar(50)", Order = 7)]
        public string Email { get; set; }

        [Column(TypeName = "text", Order = 8)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 9)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 10)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 11)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}
