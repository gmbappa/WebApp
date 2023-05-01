using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class BlogPost
    {
        public BlogPost()
        {
            BlogPostDetail = new HashSet<BlogPostDetail>();
            BlogPostComment = new HashSet<BlogPostComment>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [ForeignKey("Profile")]
        [Column(Order = 2)]
        [Required]
        public int ProfileId { get; set; }

        [ForeignKey("BlogCategory")]
        [Column(Order = 3)]
        public int? CategoryId { get; set; }

        [ForeignKey("BlogSubCategory")]
        [Column(Order = 4)]
        public int? SubCategoryId { get; set; }

        [Column(TypeName = "int", Order = 5)]
        public int? SerialNo { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 6)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 7)]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "text", Order = 8)]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(250)", Order = 9)]
        public string Tags { get; set; }

        [Column(TypeName = "int", Order = 10)]
        [Required]
        [DefaultValue(1)]
        public int ViewCount { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 11)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 12)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 13)]
        [Required]
        [DefaultValue(false)]
        public bool IsFeatured { get; set; }

        [Column(TypeName = "bit", Order = 14)]
        [Required]
        [DefaultValue(false)]
        public bool IsCommentPossible { get; set; }

        [Column(TypeName = "bit", Order = 15)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        public virtual Profile Profile { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
        public virtual BlogSubCategory BlogSubCategory { get; set; }
        public virtual ICollection<BlogPostDetail> BlogPostDetail { get; set; }
        public virtual ICollection<BlogPostComment> BlogPostComment { get; set; }
    }
}
