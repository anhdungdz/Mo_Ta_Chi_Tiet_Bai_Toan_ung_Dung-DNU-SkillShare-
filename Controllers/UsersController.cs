using Microsoft.AspNetCore.Mvc;
using DashboardDaiNam.Models;
using DashboardDaiNam.Data;
using System.Linq;

namespace DashboardDaiNam.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users
                .ToList()
                .Select(u => new UserModel
                {
                    Ten = u.Name,
                    Email = u.Email,
                    KyNang = u.Skill, // hoặc string.Join(", ", u.Skills.Select(s => s.Name)) nếu là list
                    VaiTro = u.Role,
                    NgayTao = u.CreatedAt
                }).ToList();

            return View(users);
        }



        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user == null) return NotFound();

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.Role = updatedUser.Role;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult SharePost()
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
                return RedirectToAction("Login", "Account");

            return View();
        }
        public IActionResult Home()
        {
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Login", "Account");
            }

            var user = _context.Users.FirstOrDefault(u => u.Name == username);
            return View(user); // → cần file Home.cshtml như trên
        }

    }
    
}