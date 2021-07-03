using RentalTracker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public interface ICommonService
    {
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
