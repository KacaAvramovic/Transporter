using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;
using Persistence.Entities;

namespace Persistence
{
    public class TransporterContext : DbContext
    {
        public TransporterContext(DbContextOptions<TransporterContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<User>().ToTable("Users");
            
            builder.ApplyConfiguration(new UserEntityConfigurations());
        }
    }
}
