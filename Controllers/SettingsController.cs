using Microsoft.AspNetCore.Mvc;

namespace DashboardDaiNam.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccountSettings()
        {
            return View();
        }

        public IActionResult PersonalInfo()
        {
            return View();
        }

        public IActionResult Notifications()
        {
            return View();
        }

        public IActionResult Language()
        {
            return View();
        }

        public IActionResult DataSettings()
        {
            return View();
        }

        public IActionResult PersonalData()
        {
            return View();
        }

        public IActionResult Security()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}