using Microsoft.AspNetCore.Mvc;
using WebApp; // namespace chứa ApplicationDbContext
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    public class TestDbController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("/test-db")]
        public IActionResult Index()
        {
            try
            {
                bool canConnect = _context.Database.CanConnect();
                if (canConnect)
                    return Content("Kết nối MySQL thành công!");
                else
                    return Content("Kết nối MySQL thất bại!");
            }
            catch (Exception ex)
            {
                return Content("Lỗi khi kết nối MySQL: " + ex.Message);
            }
        }
    }
}