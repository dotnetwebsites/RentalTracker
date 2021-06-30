using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace RentalTracker.Web.DAL
{
    public class TenantService : ITenantService
    {
        private readonly ApplicationDbContext _repository;

        public TenantService(ApplicationDbContext repository)
        {
            _repository = repository;
        }

        public TenantMaster FindById(int? id)
        {
            return _repository.TenantMasters.SingleOrDefault(p => p.Id == id);
        }

        public ICollection<TenantMaster> GetAllRecords()
        {
            return _repository.TenantMasters.ToList();
        }

        public void SaveTenant(TenantMaster tenantMaster)
        {
            _repository.TenantMasters.Add(tenantMaster);
            _repository.SaveChanges();
        }

        public void UpdateTenant(TenantMaster tenantMaster)
        {
            //_repository.Entry(tenantMaster).State = EntityState.Modified;
            _repository.SaveChanges();
        }
    }
}
