namespace Fl8xy.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Fl8xy.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<UserProjects> UserProjects { get; set; }

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
        }
    }
}
