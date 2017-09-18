using System.Data.Entity;

namespace Dreamer.HR
{
    public class HRdbContext : DbContext
    {
        public HRdbContext() : base("HRdb")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<HR, DAL.Migrations.Configuration>());
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
