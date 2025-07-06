using Microsoft.AspNetCore.Mvc;

namespace DashboardDaiNam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ✅ Chuyển hướng về Dashboard/Index
            return RedirectToAction("Index", "Dashboard");
        }

    }
}