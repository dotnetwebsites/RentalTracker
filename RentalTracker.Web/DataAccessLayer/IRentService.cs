using RentalTracker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public interface IRentService
    {
        ICollection<Rent> GetAllRecords();
        Rent FindById(int? id);

        Task<Rent> FindAsync(int? id);

        ICollection<Rent> GetAllRentsByTenantId(int? tenantId);

        Task<ICollection<Rent>> GetAllRentsByTenantIdAsync(int? tenantId);

        void AddRent(Rent tenantMaster);
        void UpdateRent(Rent tenantMaster);
        void RemoveRent(Rent tenantMaster);
        void SaveRentChanges();
    }
}
