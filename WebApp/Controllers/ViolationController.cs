using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp;
using WebApp.Models;
using System.Diagnostics;

namespace WebApp.Controllers
{
    public class ViolationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ViolationController> _logger;

        public ViolationController(ApplicationDbContext context, ILogger<ViolationController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index(string status = "all")
        {
            // Lấy ID người dùng từ session
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                TempData["ErrorMsg"] = "Vui lòng đăng nhập để xem thông tin vi phạm!";
                return RedirectToAction("Index", "Login");
            }

            _logger.LogInformation($"Current status filter: {status}");

            // Lấy email người dùng từ session
            ViewBag.UserEmail = HttpContext.Session.GetString("email");

            // Lấy danh sách vi phạm của người dùng
            var query = _context.Violations
                .Include(v => v.Device)
                .Where(v => v.UserId == userId);

            // Lọc theo trạng thái
            if (status != "all")
            {
                query = query.Where(v => v.StatusString == status);
            }

            // Sắp xếp theo thời gian mới nhất
            var violations = query.OrderByDescending(v => v.DateReported).ToList();
            _logger.LogInformation($"Found {violations.Count} violations");

            // Truyền trạng thái hiện tại vào ViewBag
            ViewBag.CurrentStatus = status;

            return View(violations);
        }
    }
} 