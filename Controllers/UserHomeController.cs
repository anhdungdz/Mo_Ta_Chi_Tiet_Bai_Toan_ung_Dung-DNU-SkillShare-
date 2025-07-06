using Microsoft.AspNetCore.Mvc;

namespace DashboardDaiNam.Controllers
{
    public class UserHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}