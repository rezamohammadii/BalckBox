using Microsoft.EntityFrameworkCore;
using WorkForDb.Database.Entity;

namespace WorkForDb.Database.Context
{
    public class MariaDbContext : DbContext
    {
        public MariaDbContext()
        {

        }
        public MariaDbContext(DbContextOptions<MariaDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conn = "server=localhost;user id=root;password=1qaz!QAZ;database=cloudguard";
            // connect to sqlserver database
            options.UseMySql(conn, ServerVersion.AutoDetect(conn));
        }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<FieldStudy> FieldStudies { get; set; } = null!;
    }
}
