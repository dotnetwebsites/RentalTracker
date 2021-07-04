using Microsoft.AspNetCore.Hosting;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace RentalTracker.Web.DAL
{
    public class TenantService : ITenantService
    {
        private readonly ApplicationDbContext _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ICommonService _commonService;

        public TenantService(ApplicationDbContext repository,
                            IWebHostEnvironment webHostEnvironment,
                            ICommonService commonService)
        {
            _repository = repository;
            _webHostEnvironment = webHostEnvironment;
            _commonService = commonService;
        }

        public TenantMaster FindById(int? id)
        {
            return _repository.TenantMasters.SingleOrDefault(p => p.Id == id);
        }

        public ICollection<TenantMaster> GetAllRecords()
        {
            return _repository.TenantMasters.ToList();
        }

        public void SaveTenantChanges()
        {
            _repository.SaveChanges();
        }

        public void AddTenant(TenantMaster tenantMaster)
        {
            tenantMaster.ProfileImageUrl = _commonService.UploadedFile(tenantMaster.ProfileImageUrl, tenantMaster.ProfileImage, Directories.profileimages);
            tenantMaster.DocUrl = _commonService.UploadedFile(tenantMaster.DocUrl, tenantMaster.UploadDoc, Directories.documents);
            _repository.TenantMasters.Add(tenantMaster);
        }

        public void RemoveTenant(TenantMaster tenantMaster)
        {
        }
    }
}
