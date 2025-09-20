using Microsoft.EntityFrameworkCore;

namespace Eproject1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Student> Students { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<Admin> Admins { get; set; }


        public DbSet<Competition> Competitions { get; set; }

        public DbSet<Submission> Submissions { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<Exhibition> Exhibitions { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<AcademicRecord> AcademicRecords { get; set; }
    }
}
