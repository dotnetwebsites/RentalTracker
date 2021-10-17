using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RentalTracker.Web.DAL;
using RentalTracker.Web.Models;
using System.Diagnostics;

namespace RentalTracker.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITenantService _tenantService;
        
        public HomeController(ILogger<HomeController> logger, ITenantService tenantService)
        {
            _logger = logger;
            _tenantService = tenantService;
        }

        public IActionResult Index()
        {
            var tenants = _tenantService.GetAllRecords();
            return View(tenants);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
