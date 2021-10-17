using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public class RentService : IRentService
    {
        private readonly ApplicationDbContext _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ICommonService _commonService;

        public RentService(ApplicationDbContext repository,
                            IWebHostEnvironment webHostEnvironment,
                            ICommonService commonService)
        {
            _repository = repository;
            _webHostEnvironment = webHostEnvironment;
            _commonService = commonService;
        }

        public Rent FindById(int? id)
        {
            return _repository.Rents.Find(id);
        }

        public async Task<Rent> FindAsync(int? id)
        {
            return await _repository.Rents.FindAsync(id);
        }

        public ICollection<Rent> GetAllRecords()
        {
            return _repository.Rents.ToList();
        }

        public void SaveRentChanges()
        {
            _repository.SaveChanges();
        }

        public void AddRent(Rent rent)
        {
            _repository.Rents.Add(rent);
        }

        public void UpdateRent(Rent rent)
        {
            Rent model = _repository.Rents.Find(rent.RentId);

        }

        public void RemoveRent(Rent rent)
        {
        }

        public ICollection<Rent> GetAllRentsByTenantId(int? tenantId)
        {
            return _repository.Rents.Where(p => p.TenantId == tenantId).ToList();
        }

        public async Task<ICollection<Rent>> GetAllRentsByTenantIdAsync(int? tenantId)
        {
            return await _repository.Rents.Where(p => p.TenantId == tenantId).ToListAsync();
        }
    }
}
