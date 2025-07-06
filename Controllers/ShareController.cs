using Microsoft.AspNetCore.Mvc;

namespace DashboardDaiNam.Controllers
{
    public class ShareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}