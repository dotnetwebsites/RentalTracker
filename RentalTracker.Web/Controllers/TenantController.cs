using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RentalTracker.Web.DAL;
using RentalTracker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentalTracker.Web.Controllers
{
    [Authorize]
    public class TenantController : Controller
    {
        private readonly ILogger<TenantController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ITenantService _tenantService;
        private readonly ICommonService _commonService;

        public TenantController(ILogger<TenantController> logger,
                              IWebHostEnvironment webHostEnvironment,
                              ITenantService tenantService,
                              ICommonService commonService)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _tenantService = tenantService;
            _commonService = commonService;
        }

        public IActionResult Index()
        {
            var tenants = _tenantService.GetAllRecords();
            return View(tenants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryId = new SelectList(_commonService.CountryLists(), "CountryId", "CountryName", 1);
            ViewBag.StateId = new SelectList(_commonService.StateLists(), "StateId", "StateName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(TenantMaster model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = User.FindFirstValue(ClaimTypes.NameIdentifier);

                _tenantService.AddTenant(model);
                _tenantService.SaveTenantChanges();

                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(_commonService.CountryLists(), "CountryId", "CountryName", model.CountryId);
            ViewBag.StateId = new SelectList(_commonService.StateLists(), "StateId", "StateName", model.StateId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            TenantMaster model = await _tenantService.FindAsync(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }

            City city = await _commonService.CityByIdAsync(model.CityId);
            State state = await _commonService.StateByIdAsync(city.StateId);
            Country country = await _commonService.CountryByIdAsync(state.CountryId);

            ViewBag.CountryId = new SelectList(await _commonService.CountryListsAsync(), "CountryId", "CountryName", country.CountryId);
            ViewBag.StateId = new SelectList(await _commonService.StateListByCountryIdAsync(country.CountryId), "StateId", "StateName", state.StateId);
            ViewBag.CityId = new SelectList(await _commonService.CityListByStateIdAsync(state.StateId), "CityId", "CityName", city.CityId);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TenantMaster model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = User.FindFirstValue(ClaimTypes.NameIdentifier);
                model.UpdatedDate = DateTime.Now;

                _tenantService.UpdateTenant(model);
                _tenantService.SaveTenantChanges();

                return RedirectToAction("Index");
            }

            City city = await _commonService.CityByIdAsync(model.CityId);
            State state = await _commonService.StateByIdAsync(city.StateId);
            Country country = await _commonService.CountryByIdAsync(state.CountryId);

            ViewBag.CountryId = new SelectList(await _commonService.CountryListsAsync(), "CountryId", "CountryName", country.CountryId);
            ViewBag.StateId = new SelectList(await _commonService.StateListByCountryIdAsync(country.CountryId), "StateId", "StateName", state.StateId);
            ViewBag.CityId = new SelectList(await _commonService.CityListByStateIdAsync(state.StateId), "CityId", "CityName", city.CityId);

            return View(model);
        }


        [HttpGet]
        public async Task<JsonResult> LoadCities(int id)
        {
            var cities = await _commonService.CityListByStateIdAsync(id);
            return Json(new SelectList(cities, "CityId", "CityName"));
        }

        [Authorize(Roles = "admin")]
        [HttpGet, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            TenantMaster tenantMaster = await _tenantService.FindAsync(id);

            _tenantService.RemoveTenant(tenantMaster);
            _tenantService.SaveTenantChanges();

            return RedirectToAction("Index");
        }
    }
}
