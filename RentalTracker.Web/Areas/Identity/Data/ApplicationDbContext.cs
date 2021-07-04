using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentalTracker.Web.Models;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Utilities;

namespace RentalTracker.Web.Areas.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetUserRoleMenu> AspNetUserRoleMenus { get; set; }
        public DbSet<TenantMaster> TenantMasters { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<MailLibrary> MailLibraries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<TenantMaster>()
            //    .HasMany(c => c.TenantRelatedStates)
            //    .WithMany(t => t.RelatedTenants);


            //.WillCascadeOnDelete();

            //builder.Entity<Curator>()
            //    .HasIndex(u => new { u.ProfileName })
            //    .IsUnique();

            builder.Seed();
        }

    }

}