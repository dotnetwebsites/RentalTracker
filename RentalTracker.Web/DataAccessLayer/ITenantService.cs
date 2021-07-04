using RentalTracker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public interface ITenantService
    {
        ICollection<TenantMaster> GetAllRecords();
        TenantMaster FindById(int? id);

        Task<TenantMaster> FindAsync(int? id);

        //TenantMaster FindPayeeWithTransactions(int? id, DateTime? from = null, DateTime? to = null, bool ascending = true);
        void AddTenant(TenantMaster tenantMaster);
        void UpdateTenant(TenantMaster tenantMaster);
        void RemoveTenant(TenantMaster tenantMaster);
        void SaveTenantChanges();
    }
}
