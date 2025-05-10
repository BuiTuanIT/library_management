using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Index(User model)
        {
            Console.WriteLine($"UserName: {model.UserName}, Password: {model.Password}");
            if (ModelState.IsValid)
            {
                var user = _context.Users
                    .FirstOrDefault(u => u.UserName == model.UserName && u.Password == model.Password);

                if (user != null)
                {
                    // Kiểm tra trạng thái tài khoản
                    if (user.is_active == 0)
                    {
                        TempData["ErrorMsg"] = "Tài khoản của bạn đã bị khóa. Vui lòng liên hệ quản trị viên.";
                        return View(model);
                    }

                    // Đăng nhập thành công
                    HttpContext.Session.SetString("UserName", user.UserName);
                    HttpContext.Session.SetString("email", user.email ?? "");
                    HttpContext.Session.SetInt32("UserId", user.UserId);

                    TempData["SuccessMsg"] = "Đăng nhập thành công!";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["ErrorMsg"] = "Sai tên đăng nhập hoặc mật khẩu!";
                }
            }
            else
            {
                Console.WriteLine("ModelState không hợp lệ");
            }
            return View(model);
        }

        public IActionResult Logout()
        {
            TempData["SuccessMsg"] = "Bái Bai!";
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
