using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public class CommonService : ICommonService
    {
        private readonly ApplicationDbContext _repository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CommonService(ApplicationDbContext repository,
                            IWebHostEnvironment webHostEnvironment)
        {
            _repository = repository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<City> CityById(int? id)
        {
            if (id == null)
                return null;

            return await _repository.Cities.FindAsync(id);
        }

        public async Task<State> StateById(int? id)
        {
            if (id == null)
                return null;

            return await _repository.States.FindAsync(id);
        }

        public async Task<Country> CountryById(int? id)
        {
            if (id == null)
                return null;

            return await _repository.Countries.FindAsync(id);
        }


        public ICollection<Country> CountryLists()
        {
            return _repository.Countries.ToList();
        }

        public async Task<ICollection<Country>> CountryListsAsync()
        {
            return await _repository.Countries.ToListAsync();
        }


        public ICollection<State> StateLists()
        {
            return _repository.States.ToList();
        }

        public async Task<ICollection<State>> StateListsAsync()
        {
            return await _repository.States.ToListAsync();
        }

        public async Task<ICollection<State>> StateLists(int? countryId)
        {
            if (countryId == null)
                return await _repository.States.ToListAsync();
            else
                return await _repository.States.Where(p => p.CountryId == countryId).ToListAsync();
        }

        public ICollection<City> CityLists()
        {
            return _repository.Cities.ToList();
        }

        public async Task<ICollection<City>> CityListsAsync()
        {
            return await _repository.Cities.ToListAsync();
        }

        public async Task<ICollection<City>> CityLists(int? stateId)
        {
            if (stateId == null)
                return await _repository.Cities.ToListAsync();
            else
                return await _repository.Cities.Where(p => p.StateId == stateId).ToListAsync();
        }

        public void DeleteFileIfExists(string fileUrl, Directories directories)
        {
            if (fileUrl != null)
            {
                var path = fileUrl == null ? null :
                    Path.Combine(_webHostEnvironment.WebRootPath, directories.ToString() + "/", fileUrl);

                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
        }

        public string UploadedFile(string Url, IFormFile formFile, Directories directoryName)
        {
            if (Url != null)
            {
                var path = Url == null ? null :
                    Path.Combine(_webHostEnvironment.WebRootPath, directoryName.ToString() + "/", Url);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }

            string uniqueFileName = null;

            if (formFile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, directoryName.ToString() + "/");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
