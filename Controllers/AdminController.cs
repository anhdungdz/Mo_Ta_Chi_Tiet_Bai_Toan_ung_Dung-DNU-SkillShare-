using Microsoft.AspNetCore.Mvc;

namespace DashboardDaiNam.Controllers;

public class AdminController : Controller
{
    public IActionResult Home()
    {
        return View();
    }
}
