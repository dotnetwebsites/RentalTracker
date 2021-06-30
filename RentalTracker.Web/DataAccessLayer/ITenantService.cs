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

        //TenantMaster FindPayeeWithTransactions(int? id, DateTime? from = null, DateTime? to = null, bool ascending = true);
        void SaveTenant(TenantMaster tenantMaster);

        void UpdateTenant(TenantMaster tenantMaster);

    }
}
