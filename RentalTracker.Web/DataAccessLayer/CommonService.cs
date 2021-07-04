using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
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

        public async Task<City> CityByIdAsync(int? id)
        {
            if (id == null)
                return null;

            return await _repository.Cities.FindAsync(id);
        }

        public async Task<State> StateByIdAsync(int? id)
        {
            if (id == null)
                return null;

            return await _repository.States.FindAsync(id);
        }

        public async Task<Country> CountryByIdAsync(int? id)
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

        public async Task<ICollection<City>> CityListByStateIdAsync(int? stateId)
        {
            if (stateId == null)
                return await _repository.Cities.ToListAsync();
            else
                return await _repository.Cities.Where(p => p.StateId == stateId).ToListAsync();
        }

        public async Task<ICollection<City>> GetCityStateCountryLists(int? cityId)
        {
            var cities = await _repository.Cities
                .Include(p => p.State)
                .Where(c => c.CityId == cityId)
                .ToListAsync();

            //if (stateId == null)
            //    return await _repository.Cities.ToListAsync();
            //else
            //    return await _repository.Cities.Where(p => p.StateId == stateId).ToListAsync();

            return cities; //await _repository.Cities.ToListAsync();
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
            string uniqueFileName = null;

            if (formFile != null)
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

                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, directoryName.ToString() + "/");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;
                
                var extension = Path.GetExtension(formFile.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                
                if (extension.ToLower() == ".xlsx" || extension.ToLower() == ".pdf")
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        formFile.CopyTo(fileStream);
                    }
                }
                else
                {
                    using (var image = Image.Load(formFile.OpenReadStream()))
                    {
                        int[] size = ResizeImage(image, 200, 200);
                        image.Mutate(p => p.Resize(size[0], size[1]));
                        image.Save(filePath);
                    }
                }

            }

            return uniqueFileName;
        }

        public string UploadedFile(string Url, IFormFile formFile, Directories directoryName, int width, int height)
        {
            string uniqueFileName = null;

            if (formFile != null)
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

                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, directoryName.ToString() + "/");

                if (!Directory.Exists(uploadsFolder))
                    Directory.CreateDirectory(uploadsFolder);

                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;

                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                var extension = Path.GetExtension(formFile.FileName);

                if (extension.ToLower() == ".xlsx" || extension.ToLower() == ".pdf")
                {
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        formFile.CopyTo(fileStream);
                    }
                }
                else
                {
                    using (var image = Image.Load(formFile.OpenReadStream()))
                    {
                        int[] size = ResizeImage(image, width, height);
                        image.Mutate(p => p.Resize(size[0], size[1]));
                        image.Save(filePath);
                    }
                }

            }

            return uniqueFileName;
        }

        public int[] ResizeImage(Image img, int maxWidth, int maxHeight)
        {
            int[] val = new int[2];

            if (img.Width > maxWidth || img.Height > maxHeight)
            {
                double widthRatio = (double)img.Width / (double)maxWidth;
                double heightRatio = (double)img.Height / (double)maxHeight;

                double ratio = Math.Max(widthRatio, heightRatio);
                int newWidth = (int)(img.Width / ratio);
                int newHeight = (int)(img.Height / ratio);

                val[0] = newWidth;
                val[1] = newHeight;

                return val;
                //return newHeight.ToString() + "," + newWidth.ToString();
            }
            else
            {
                val[0] = img.Width;
                val[1] = img.Height;

                return val;

                //return img.Height.ToString() + "," + img.Width.ToString();
            }
        }

        public async Task<ICollection<State>> StateListByCountryIdAsync(int? countryId)
        {
            if (countryId == null)
                return await _repository.States.ToListAsync();
            else
                return await _repository.States.Where(p => p.CountryId == countryId).ToListAsync();
        }
    }
}
