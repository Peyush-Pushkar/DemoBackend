using Microsoft.EntityFrameworkCore;

namespace DemoProject01.Entities
{
    public class DemoProjectDbContext : DbContext
    {

        public DemoProjectDbContext(DbContextOptions options) : base(options) 
        {
        
        }

        public DbSet<TestEntity> TestEntity {  get; set; }
        public DbSet<TestEntity2> TestEntity2 { get; set; }

    }
}
