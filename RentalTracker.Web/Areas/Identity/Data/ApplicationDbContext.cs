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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Curator>()
            //    .HasIndex(u => new { u.ProfileName })
            //    .IsUnique();

            builder.Seed();
        }

        //public DbSet<MailLibrary> MailLibraries { get; set; }

    }

}

//context.Countries.AddOrUpdate(p => p.CountryName, new Models.Country { CountryId = 1, CountryCode = "IN", CountryName = "India", ShortName = "IND", CreatedBy = "SystemGenerated" });

//context.States.AddOrUpdate(p => p.StateName, new Models.State { StateId = 1, CountryId = 1, StateCode = "MP", StateName = "Madhya Prades", ShortName = "MP", CreatedBy = "SystemGenerated" });
