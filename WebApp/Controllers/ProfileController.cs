using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

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

            // Lấy lịch sử check-in của user
            var accessLogs = _context.StudyAreaAccessLogs
                .Where(log => log.UserId == user.UserId)
                .OrderByDescending(log => log.AccessTime)
                .ToList();

            ViewBag.AccessLogs = accessLogs;
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(User model)
        {
            _logger.LogInformation("Bắt đầu cập nhật thông tin user");
            
            if (ModelState.IsValid)
            {
                _logger.LogInformation("ModelState hợp lệ");
                var userName = HttpContext.Session.GetString("UserName");
                _logger.LogInformation($"UserName từ session: {userName}");
                
                var user = _context.Users.FirstOrDefault(u => u.UserName == userName);
                if (user != null)
                {
                    _logger.LogInformation("Tìm thấy user trong database");
                    // Cập nhật thông tin
                    user.email = model.email;
                    user.phone = model.phone;
                    user.Birthday = model.Birthday;
                    user.Sex = model.Sex;
                    user.student_code = model.student_code;

                    try 
                    {
                        _context.SaveChanges();
                        _logger.LogInformation("Lưu thông tin thành công");
                        TempData["SuccessMsg"] = "Cập nhật thông tin thành công!";
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError($"Lỗi khi lưu: {ex.Message}");
                        TempData["ErrorMsg"] = "Có lỗi xảy ra khi cập nhật: " + ex.Message;
                    }
                }
                else
                {
                    _logger.LogWarning("Không tìm thấy user trong database");
                    TempData["ErrorMsg"] = "Không tìm thấy thông tin người dùng!";
                }
            }
            else
            {
                var errors = string.Join("; ", ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));
                _logger.LogWarning($"ModelState không hợp lệ: {errors}");
                TempData["ErrorMsg"] = "Dữ liệu không hợp lệ: " + errors;
            }
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