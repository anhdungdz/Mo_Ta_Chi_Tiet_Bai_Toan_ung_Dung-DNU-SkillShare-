using Microsoft.AspNetCore.Mvc;

namespace DashboardDaiNam.Controllers
{
    public class RatingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}