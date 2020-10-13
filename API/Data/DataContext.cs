using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<College> Colleges { get; set; }
        public DbSet<ColUser> ColUsers { get; set; }
        public DbSet<EmpUser> EmpUsers { get; set; }
        public DbSet<HsUser> HsUsers { get; set; }
    }
}