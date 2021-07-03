using Microsoft.EntityFrameworkCore;
using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public class CommonService : ICommonService
    {
        private readonly ApplicationDbContext _repository;

        public CommonService(ApplicationDbContext repository)
        {
            _repository = repository;
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

    }
}
