using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http; // Đảm bảo có thư viện này để dùng Session

namespace WebApp.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ApplicationDbContext context, ILogger<ProfileController> logger)
        {
            _context = context;
            _logger = logger;
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

            var accessLogs = _context.StudyAreaAccessLogs
                .Where(log => log.UserId == user.UserId)
                .OrderByDescending(log => log.AccessTime)
                .ToList();

            ViewBag.AccessLogs = accessLogs;
            _logger.LogInformation("User email: " + user.email); // Kiểm tra giá trị email
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int UserId, string email, string phone, string student_code, DateTime? Birthday, string Sex)
        {
            // Lấy user theo chính xác UserId
            var user = _context.Users.Find(UserId);
            if (user == null)
            {
                TempData["ErrorMsg"] = "Không tìm thấy người dùng!";
                return RedirectToAction("Index");
            }

            // Cập nhật các trường
            user.email = email;
            user.phone = phone;
            user.student_code = student_code;
            user.Birthday = Birthday;
            user.Sex = Sex;

            // Lưu thay đổi
            _context.SaveChanges();
            TempData["SuccessMsg"] = "Cập nhật thành công!";
            return RedirectToAction("Index");
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
            if (user == null)
            {
                TempData["ErrorMsg"] = "Không tìm thấy người dùng để check-in!";
                return RedirectToAction("Index");
            }

            var log = new StudyAreaAccessLogs
            {
                UserId = user.UserId,
                AccessTime = DateTime.Now
            };

            _context.StudyAreaAccessLogs.Add(log);
            _context.SaveChanges();

            TempData["SuccessMsg"] = "Check-in thành công!";
            return RedirectToAction("Index");
        }
    }
}
