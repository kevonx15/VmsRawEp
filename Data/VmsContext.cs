using VmsRawEp.Models;
using Microsoft.EntityFrameworkCore;

namespace VmsRawEp.Data
{
    public class VmsContext: DbContext
    {
        public VmsContext(DbContextOptions<VmsContext> options) : base(options)
        {
        }
        public DbSet<Volunteer> Volunteers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            modelBuilder.Entity<Volunteer>().ToTable("Volunteer");


        }
    }
}
