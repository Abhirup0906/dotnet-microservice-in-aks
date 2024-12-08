using dotnetMSInAKS.EF.DbModel;
using Microsoft.EntityFrameworkCore;

namespace dotnetMSInAKS.EF
{
    public class AdventureDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdventureDbContext).Assembly);
        }
    }
}
