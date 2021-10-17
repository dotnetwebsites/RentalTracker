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
    public class RentController : Controller
    {
        private readonly ILogger<RentController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IRentService _rentService;
        private readonly ITenantService _tenantService;
        private readonly ICommonService _commonService;

        public RentController(ILogger<RentController> logger,
                              IWebHostEnvironment webHostEnvironment,
                              IRentService rentService,
                              ITenantService tenantService,
                              ICommonService commonService)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _rentService = rentService;
            _commonService = commonService;
            _tenantService = tenantService;
        }

        public IActionResult Index()
        {
            var rents = _rentService.GetAllRecords();
            return View(rents);
        }

        [HttpGet]
        [Route("/{controller}/{action}/{tenantId}")]
        public IActionResult Create(int? tenantId)
        {
            if (tenantId != null)
            {
                ViewBag.TenantId = new SelectList(_tenantService.GetAllRecords(), "TenantId", "FullName", tenantId);
                return View();
            }

            ViewBag.TenantId = new SelectList(_tenantService.GetAllRecords(), "TenantId", "FullName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Rent model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedBy = User.FindFirstValue(ClaimTypes.NameIdentifier);

                _rentService.AddRent(model);
                _rentService.SaveRentChanges();

                return RedirectToAction("Index");
            }

            ViewBag.TenantId = new SelectList(_tenantService.GetAllRecords(), "TenantId", "FullName", model.TenantId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Rent model = await _rentService.FindAsync(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.TenantId = new SelectList(_tenantService.GetAllRecords(), "TenantId", "FullName", model.TenantId);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Rent model)
        {
            if (ModelState.IsValid)
            {
                model.UpdatedBy = User.FindFirstValue(ClaimTypes.NameIdentifier);
                model.UpdatedDate = DateTime.Now;

                _rentService.UpdateRent(model);
                _rentService.SaveRentChanges();

                return RedirectToAction("Index");
            }

            ViewBag.TenantId = new SelectList(_tenantService.GetAllRecords(), "TenantId", "FullName", model.TenantId);
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
            Rent rent = await _rentService.FindAsync(id);

            _rentService.RemoveRent(rent);
            _rentService.SaveRentChanges();

            return RedirectToAction("Index");
        }
    }
}
