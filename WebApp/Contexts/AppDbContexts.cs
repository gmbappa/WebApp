using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Contexts
{
    public class AppDbContexts : DbContext
    {
        public AppDbContexts() { }

        public AppDbContexts(DbContextOptions<AppDbContexts> options) : base(options) { }

        public DbSet<AboutClient> AboutClient { get; set; }
        public DbSet<AboutDescription> AboutDescription { get; set; }
        public DbSet<AboutProject> AboutProject { get; set; }
        public DbSet<AboutService> AboutService { get; set; }
        public DbSet<AboutSkill> AboutSkill { get; set; }
        public DbSet<BlogCategory> BlogCategory { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<BlogPostComment> BlogPostComment { get; set; }
        public DbSet<BlogPostDetail> BlogPostDetail { get; set; }
        public DbSet<BlogSubCategory> BlogSubCategory { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<ResumeCertification> ResumeCertification { get; set; }
        public DbSet<ResumeEducation> ResumeEducation { get; set; }
        public DbSet<ResumeFile> ResumeFile { get; set; }
        public DbSet<ResumeTestimony> ResumeTestimony { get; set; }
        public DbSet<ResumeTraining> ResumeTraining { get; set; }
        public DbSet<ResumeWork> ResumeWork { get; set; }
        public DbSet<Visitor> Visitor { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserToken> UserToken { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Entity<UserRole>().HasNoKey();
        }
    }
}
