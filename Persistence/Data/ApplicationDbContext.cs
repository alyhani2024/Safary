using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TourReview> TourReviews { get; set; }
        public DbSet<TourGuideReview> TourGuideReviews { get; set; }
        public DbSet<SelectedTourGuide> SelectedTourGuides { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourImage> TourImages { get; set; }
        public DbSet<TourBlog> TourBlogs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // SelectedTourGuide configuration
            modelBuilder.Entity<SelectedTourGuide>()
                .HasKey(st => st.Id);

            modelBuilder.Entity<SelectedTourGuide>()
                .HasOne(st => st.Tourist)
                .WithMany(u => u.Tourists)
                .HasForeignKey(st => st.TouristId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SelectedTourGuide>()
                .HasOne(st => st.Tourguide)
                .WithMany(u => u.Tourguides)
                .HasForeignKey(st => st.TourguideId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SelectedTourGuide>()
                .HasOne(st => st.Tour)
                .WithMany(t => t.SelectedTourGuides)
                .HasForeignKey(st => st.TourName)
                .HasPrincipalKey(t => t.Name);

            // Ensure Tour.Id is identity column
            modelBuilder.Entity<Tour>()
                .Property(t => t.Id)
                .UseIdentityColumn();

            // Unique selection rule
            modelBuilder.Entity<SelectedTourGuide>()
                .HasIndex(st => new { st.TouristId, st.TourguideId, st.SelectedDate })
                .IsUnique();

            // Fix decimal precision warning
            modelBuilder.Entity<ApplicationUser>()
                .Property(u => u.HourPrice)
                .HasPrecision(18, 2);

            base.OnModelCreating(modelBuilder);
        }
    }
}
