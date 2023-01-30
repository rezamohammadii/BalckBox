using Microsoft.EntityFrameworkCore;
using WorkForDb.Database.Entity;

namespace WorkForDb.Database.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        //public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlserver database
            options.UseSqlServer("Data Source=.;Initial Catalog=WorkDb;Integrated Security=True;");
        }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<FieldStudy> FieldStudies { get; set; } = null!;
    }
}
