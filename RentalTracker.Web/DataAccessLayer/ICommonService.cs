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

        ICollection<Country> CountryLists();
        Task<ICollection<Country>> CountryListsAsync();

        ICollection<State> StateLists();
        Task<ICollection<State>> StateListsAsync();


        Task<ICollection<State>> StateLists(int? countryId);

        ICollection<City> CityLists();
        Task<ICollection<City>> CityListsAsync();


        Task<ICollection<City>> CityLists(int? stateId);


        Task<Country> CountryById(int? id);
        Task<State> StateById(int? id);
        Task<City> CityById(int? id);

    }
}
