using BOL;
using System.Data.Entity;

namespace DAL
{
    public class DTPdbContext : DbContext
    {
        public DTPdbContext() : base("DTPdb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DTPdbContext, DAL.Migrations.Configuration>());
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
