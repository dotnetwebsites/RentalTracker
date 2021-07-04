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
        public async Task<JsonResult> LoadCities(int id)
        {
            var cities = await _commonService.CityLists(id);
            return Json(new SelectList(cities, "CityId", "CityName"));
        }
    }
}
