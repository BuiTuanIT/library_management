using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User model, string ConfirmPassword)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Vui lòng nhập đầy đủ thông tin!";
                return View(model);
            }

            if (model.Password != ConfirmPassword)
            {
                TempData["ErrorMessage"] = "Mật khẩu xác nhận không khớp!";
                return View(model);
            }

            if (_context.Users.Any(u => u.UserName == model.UserName))
            {
                TempData["ErrorMessage"] = "Tên đăng nhập đã tồn tại!";
                return View(model);
            }
            if (_context.Users.Any(u => u.email == model.email))
            {
                TempData["ErrorMessage"] = "Email đã tồn tại!";
                return View(model);
            }

            if (_context.Users.Any(u => u.student_code == model.student_code))
            {
                TempData["ErrorMessage"] = "Mã số sinh viên đã tồn tại!";
                return View(model);
            }

            model.is_active = 1;
            _context.Users.Add(model);
            _context.SaveChanges();

            TempData["SuccessMessage"] = "Đăng ký thành công! Bạn có thể đăng nhập.";
            return RedirectToAction("Index", "Login");
        }
    }
}
