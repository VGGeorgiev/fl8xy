namespace Fl8xy.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Fl8xy.Models;
    using Microsoft.EntityFrameworkCore.Metadata;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<UserProjects> UserProjects { get; set; }

        public DbSet<Sprint> Sprints { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<Story> Stories { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserProjects>().HasKey(x => new { x.ProjectId, x.UserId });

            builder.Entity<UserProjects>()
                .HasOne(x => x.User)
                .WithMany(x => x.ParticipatedProjects)
                .HasForeignKey(x => x.UserId);

            builder.Entity<UserProjects>()
                .HasOne(x => x.Project)
                .WithMany(x => x.Participants)
                .HasForeignKey(x => x.ProjectId);

            builder.Entity<Story>()
                .HasOne(e => e.ParentStory)
                .WithMany(x => x.Tasks)
                .Metadata.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
