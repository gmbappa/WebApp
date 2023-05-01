using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebApp.Models
{
    public class BlogCategory
    {
        public BlogCategory()
        {
            BlogSubCategory = new HashSet<BlogSubCategory>();
            BlogPost = new HashSet<BlogPost>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 2)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 3)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text", Order = 4)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 5)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 6)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 7)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual ICollection<BlogSubCategory> BlogSubCategory { get; set; }
        public virtual ICollection<BlogPost> BlogPost { get; set; }

        public override string ToString()
        {
            StringBuilder response = new StringBuilder();
            response.AppendLine($"Name: {Name}");
            response.AppendLine($"ImageUrl: {ImageUrl}");
            response.AppendLine($"IsActive: {IsActive}");
            response.AppendLine($"CreatedAt: {CreatedAt}");
            response.AppendLine($"ModifiedAt: {ModifiedAt}");

            return response.ToString();
        }

    }
}
