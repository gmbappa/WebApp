using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Profile
    {
        public Profile()
        {
            AboutDescription = new HashSet<AboutDescription>();
            AboutSkill = new HashSet<AboutSkill>();
            AboutProject = new HashSet<AboutProject>();
            AboutClient = new HashSet<AboutClient>();
            AboutService = new HashSet<AboutService>();
            //ResumeFile = new HashSet<ResumeFile>();
            ResumeCertification = new HashSet<ResumeCertification>();
            ResumeTraining = new HashSet<ResumeTraining>();
            ResumeEducation = new HashSet<ResumeEducation>();
            ResumeWork = new HashSet<ResumeWork>();
            ResumeTestimony = new HashSet<ResumeTestimony>();
            BlogPost = new HashSet<BlogPost>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(TypeName = "int", Order = 2)]
        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 3)]
        public string ImageUrl { get; set; }

        [Column(TypeName = "nvarchar(50)", Order = 4)]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(50)", Order = 5)]
        public string MiddleName { get; set; }

        [Column(TypeName = "nvarchar(50)", Order = 6)]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(150)", Order = 7)]
        public string FullName { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 8)]
        public DateTime? DoB { get; set; }

        [Column(TypeName = "nvarchar(10)", Order = 9)]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 10)]
        public string Designation { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 11)]
        public string Company { get; set; }

        [Column(TypeName = "nvarchar(250)", Order = 12)]
        public string Location { get; set; }

        [Column(TypeName = "text", Order = 13)]
        public string About { get; set; }

        [Column(TypeName = "text", Order = 14)]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 15)]
        public string FacebookLink { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 16)]
        public string LinkedInLink { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 17)]
        public string TwitterLink { get; set; }

        [Column(TypeName = "nvarchar(100)", Order = 18)]
        public string InstagramLink { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 19)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 20)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "bit", Order = 21)]
        [Required]
        [DefaultValue(false)]
        public bool IsActive { get; set; }

        [NotMapped]
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        [NotMapped]
        [DataType(DataType.PhoneNumber)]
        [Column(TypeName = "nvarchar(50)")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<AboutDescription> AboutDescription { get; set; }
        public virtual ICollection<AboutSkill> AboutSkill { get; set; }
        public virtual ICollection<AboutProject> AboutProject { get; set; }
        public virtual ICollection<AboutClient> AboutClient { get; set; }
        public virtual ICollection<AboutService> AboutService { get; set; }

        //public virtual ICollection<ResumeFile> ResumeFile { get; set; }
        public virtual ICollection<ResumeCertification> ResumeCertification { get; set; }
        public virtual ICollection<ResumeTraining> ResumeTraining { get; set; }
        public virtual ICollection<ResumeEducation> ResumeEducation { get; set; }
        public virtual ICollection<ResumeWork> ResumeWork { get; set; }
        public virtual ICollection<ResumeTestimony> ResumeTestimony { get; set; }

        public virtual ICollection<BlogPost> BlogPost { get; set; }
    }
}
