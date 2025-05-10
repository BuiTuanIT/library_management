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

            // Lấy lịch sử mượn thiết bị của user
            var borrowedDevices = _context.BorrowRecords
                .Include(b => b.Device)
                .Where(b => b.UserId == user.UserId)
                .OrderByDescending(b => b.BorrowDate)
                .ToList();

            // Truyền cả 2 danh sách vào ViewBag
            ViewBag.AccessLogs = accessLogs;
            ViewBag.BorrowedDevices = borrowedDevices;

            return View();
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