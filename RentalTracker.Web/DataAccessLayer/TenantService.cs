using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return _repository.TenantMasters.FirstOrDefault(p => p.Id == id);
        }

        public async Task<TenantMaster> FindAsync(int? id)
        {
            return await _repository.TenantMasters.FindAsync(id);
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

        public void UpdateTenant(TenantMaster tenantMaster)
        {
            TenantMaster model = _repository.TenantMasters.Find(tenantMaster.Id);

            model.HouseRent = tenantMaster.HouseRent;
            model.ReadingPerUnit = tenantMaster.ReadingPerUnit;
            model.RentStartOn = tenantMaster.RentStartOn;
            model.FirstName = tenantMaster.FirstName;
            model.MiddleName = tenantMaster.MiddleName;
            model.LastName = tenantMaster.LastName;
            model.DateOfBirth = tenantMaster.DateOfBirth;
            model.Gender = tenantMaster.Gender;
            model.FatherName = tenantMaster.FatherName;
            model.MotherName = tenantMaster.MotherName;
            model.ContactNo = tenantMaster.ContactNo;
            model.AlternateNo = tenantMaster.AlternateNo;
            model.IDType = tenantMaster.IDType;
            model.IDCardNo = tenantMaster.IDCardNo;
            model.PreviousAddress = tenantMaster.PreviousAddress;
            model.CityId = tenantMaster.CityId;
            model.Pincode = tenantMaster.Pincode;
            model.IsActive = tenantMaster.IsActive;

            model.UpdatedBy = tenantMaster.UpdatedBy;
            model.UpdatedDate = tenantMaster.UpdatedDate;

            if (tenantMaster.ProfileImage != null)
                model.ProfileImageUrl = _commonService.UploadedFile(model.ProfileImageUrl, tenantMaster.ProfileImage, Directories.profileimages);

            if (tenantMaster.UploadDoc != null)
                model.DocUrl = _commonService.UploadedFile(model.DocUrl, tenantMaster.UploadDoc, Directories.documents, 500, 700);
        }

        public void RemoveTenant(TenantMaster tenantMaster)
        {
        }
    }
}
