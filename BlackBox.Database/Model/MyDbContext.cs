using Microsoft.EntityFrameworkCore;

namespace BlackBox.Database.Model
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public MyDbContext()
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
