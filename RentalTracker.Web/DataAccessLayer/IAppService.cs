using RentalTracker.Web.Areas.Identity.Data;
using RentalTracker.Web.Models;
using System.Threading.Tasks;

namespace RentalTracker.Web.DAL
{
    public interface IAppService
    {
        bool IsAppAuthorized();
        APIResult IsApiAuthorized();
    }
}
