using Microsoft.AspNetCore.Mvc;

namespace DashboardDaiNam.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}