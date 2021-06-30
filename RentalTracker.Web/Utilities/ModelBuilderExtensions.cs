using Microsoft.EntityFrameworkCore;
using RentalTracker.Web.Models;

namespace RentalTracker.Web.Utilities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Country
            modelBuilder.Entity<Country>()
                .HasData(
                    new Country { CountryId = 1, CountryCode = "IN", CountryName = "India", ShortName = "IND", CreatedBy = "SystemGenerated" }
            );

            //State
            modelBuilder.Entity<State>()
                .HasData(
                    new State { StateId = 1, CountryId = 1, StateCode = "UP", StateName = "Uttar Prades", ShortName = "UP", CreatedBy = "SystemGenerated" },
                    new State { StateId = 2, CountryId = 1, StateCode = "MP", StateName = "Madhya Prades", ShortName = "MP", CreatedBy = "SystemGenerated" }
            );
        }
    }
}
