using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    public class HistoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userName = HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(userName))
            {
                return RedirectToAction("Index", "Login");
            }

            var user = _context.Users.FirstOrDefault(u => u.UserName == userName);
            if (user == null)
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "Login");
            }

            // Lấy lịch sử check-in của user
            var accessLogs = _context.StudyAreaAccessLogs
                .Where(log => log.UserId == user.UserId)
                .OrderByDescending(log => log.AccessTime)
                .ToList();

            return View(accessLogs);
        }

        [HttpPost]
        public IActionResult CheckIn()
        {
            var userName = HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(userName))
            {
                return RedirectToAction("Index", "Login");
            }

            var user = _context.Users.FirstOrDefault(u => u.UserName == userName);
            if (user != null)
            {
                // Tạo log mới
                var log = new StudyAreaAccessLogs
                {
                    UserId = user.UserId,
                    AccessTime = DateTime.Now
                };

                _context.StudyAreaAccessLogs.Add(log);
                _context.SaveChanges();

                TempData["SuccessMsg"] = "Check-in thành công!";
            }

            return RedirectToAction("Index");
        }
    }
} 