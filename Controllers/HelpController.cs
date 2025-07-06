using Microsoft.AspNetCore.Mvc;
using DashboardDaiNam.Models;

namespace DashboardDaiNam.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            var helpPosts = new List<HelpPost>
            {
                new HelpPost { Title = "Cần tìm người kèm môn xác suất thống kê", Description = "Tôi cần người kèm tôi môn xác suất thống kê có kinh nghiệm" },
                new HelpPost { Title = "Cần người kèm môn lập trình C", Description = "Tôi đang học yếu môn Lập trình C cần người kèm cặp" },
                new HelpPost { Title = "Cần người sửa code giúp tôi", Description = "Tôi cần người sửa code này giúp tôi" },
                new HelpPost { Title = "Cần người học tiếng anh 3", Description = "Tôi cần người học cùng tiếng anh 3" }
            };

            return View(helpPosts);
        }
    }
}