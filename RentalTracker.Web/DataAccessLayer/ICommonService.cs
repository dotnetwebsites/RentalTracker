using Microsoft.AspNetCore.Http;
using RentalTracker.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public interface ICommonService
    {
        void DeleteFileIfExists(string fileUrl, Directories directories);
        string UploadedFile(string Url, IFormFile formFile, Directories directoryName);
        string UploadedFile(string Url, IFormFile formFile, Directories directoryName, int width, int height);

        ICollection<Country> CountryLists();
        Task<ICollection<Country>> CountryListsAsync();

        ICollection<State> StateLists();
        Task<ICollection<State>> StateListsAsync();

        Task<ICollection<State>> StateListByCountryIdAsync(int? countryId);

        Task<ICollection<State>> StateLists(int? countryId);


        ICollection<City> CityLists();
        Task<ICollection<City>> CityListsAsync();


        Task<ICollection<City>> CityListByStateIdAsync(int? stateId);
        Task<ICollection<City>> GetCityStateCountryLists(int? cityId);


        Task<Country> CountryByIdAsync(int? id);
        Task<State> StateByIdAsync(int? id);
        Task<City> CityByIdAsync(int? id);

    }
}
