using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class BlogSubCategory
    {
        public BlogSubCategory()
        {
            BlogPost = new HashSet<BlogPost>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [ForeignKey("BlogCategory")]
        [Column(Order = 2)]
        [Required]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 3)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 4)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text", Order = 5)]
        public string Description { get; set; }

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

        public virtual BlogCategory BlogCategory { get; set; }
        public virtual ICollection<BlogPost> BlogPost { get; set; }
    }
}
