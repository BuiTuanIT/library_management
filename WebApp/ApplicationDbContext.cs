using Microsoft.EntityFrameworkCore;
using WebApp.Models;


namespace WebApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet cho các model, ví dụ:
        public DbSet<User> Users { get; set; }
        public DbSet<Device_Category> Device_Category { get; set; }
        public DbSet<Device> Device { get; set; }
        public DbSet<BorrowRecord> BorrowRecords { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<StudyAreaAccessLogs> StudyAreaAccessLogs { get; set; }
        public DbSet<Violation> Violations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<Device>()
                .HasOne(d => d.Category)
                .WithMany()
                .HasForeignKey(d => d.Category_Id);

            modelBuilder.Entity<StudyAreaAccessLogs>()
                .HasOne(l => l.User)
                .WithMany()
                .HasForeignKey(l => l.UserId);
        }

    }
}