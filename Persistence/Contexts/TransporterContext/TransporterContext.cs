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

        public virtual DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Invoice>().ToTable("Invoices");
            
            builder.ApplyConfiguration(new InvoiceEntityConfigurations());
        }
    }
}
