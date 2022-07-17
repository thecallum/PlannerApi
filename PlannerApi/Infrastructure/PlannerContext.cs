using Microsoft.EntityFrameworkCore;

namespace PlannerApi.Infrastructure
{
    public class PlannerContext : DbContext
    {
        public PlannerContext(DbContextOptions<PlannerContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<TestEntity> TestEntities { get; set; }
    }
}
