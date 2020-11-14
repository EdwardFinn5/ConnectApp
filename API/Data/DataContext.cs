using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<College> Colleges { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<CollegeMajor> CollegeMajors { get; set; }
        public DbSet<AppUser> Users { get; set; }
        public DbSet<ColUser> ColUsers { get; set; }
        public DbSet<MajorCat> MajorCats { get; set; }
        public DbSet<CollegePrep> CollegePreps { get; set; }
        public DbSet<HsPrep> HsPreps { get; set; }
        public DbSet<EmpOpp> EmpOpps { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<ColPhoto> ColPhotos { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CollegeMajor>()
                .HasKey(cm => new { cm.CollegeId, cm.MajorId });
               
            modelBuilder.Entity<CollegeMajor>()
                .HasOne(cm => cm.College)
                .WithMany(c => c.CollegeMajors)
                .HasForeignKey(cm => cm.CollegeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CollegeMajor>()
                .HasOne(cm => cm.Major)
                .WithMany(m => m.CollegeMajors)
                .HasForeignKey(cm => cm.MajorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MajorCat>()
                .HasMany(mc => mc.Majors)
                .WithOne(m => m.MajorCat);
        }
    }
}