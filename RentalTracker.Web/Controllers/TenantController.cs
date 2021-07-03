using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RentalTracker.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalTracker.Web.Controllers
{
    [AllowAnonymous]
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

        public IActionResult Create()
        {
            ViewBag.CountryId = new SelectList(_commonService.CountryLists(), "CountryId", "CountryName", 1);
            ViewBag.StateId = new SelectList(_commonService.StateLists(), "StateId", "StateName");
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> LoadCities(int id)
        {
            var cities = await _commonService.CityLists(id);
            return Json(new SelectList(cities, "CityId", "CityName"));
        }
    }
}
