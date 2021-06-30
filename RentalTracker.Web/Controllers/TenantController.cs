using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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

        public TenantController(ILogger<TenantController> logger,
                              IWebHostEnvironment webHostEnvironment,
                              ITenantService tenantService)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _tenantService = tenantService;
        }

        public IActionResult Index()
        {
            var tenants = _tenantService.GetAllRecords();
            return View(tenants);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
