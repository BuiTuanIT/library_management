using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Kiểm tra đăng nhập
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return RedirectToAction("Index", "Login");
            }

            // Lấy thông tin người dùng
            var user = _context.Users.FirstOrDefault(u => u.UserId == userId);
            if (user != null)
            {
                ViewBag.UserEmail = user.email;
                ViewBag.StudentCode = user.student_code;
            }

            // Lấy danh sách loại thiết bị
            var categories = _context.Device_Category.ToList();
            ViewBag.Categories = categories;

            // Lấy danh sách thiết bị có sẵn
            var devices = _context.Device
                .Include(d => d.Category)
                .Where(d => d.Is_Borrow == false)
                .ToList();
            ViewBag.Devices = devices;

            // Lấy danh sách phiếu mượn của người dùng
            var userBookings = _context.Reservations
                .Include(r => r.Device)
                    .ThenInclude(d => d.Category)
                .Where(r => r.User_Id == userId)
                .OrderByDescending(r => r.Reserve_Start)
                .ToList();
            ViewBag.UserBookings = userBookings;

            return View();
        }

        [HttpPost]
        public IActionResult CheckAvailability(int deviceId, DateTime startDate, DateTime endDate)
        {
            // Kiểm tra xem thiết bị có bị đặt trong khoảng thời gian này không
            var existingReservation = _context.Reservations
                .Where(r => r.Device_Id == deviceId &&
                           ((startDate >= r.Reserve_Start && startDate <= r.Reserve_End) ||
                            (endDate >= r.Reserve_Start && endDate <= r.Reserve_End) ||
                            (startDate <= r.Reserve_Start && endDate >= r.Reserve_End)))
                .FirstOrDefault();

            return Json(new { isAvailable = existingReservation == null });
        }

        [HttpPost]
        public IActionResult CreateBooking(int deviceId, DateTime startDate, DateTime endDate)
        {
            // Kiểm tra đăng nhập
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return Json(new { success = false, message = "Vui lòng đăng nhập để đặt thiết bị" });
            }

            // Kiểm tra tính khả dụng của thiết bị
            var isAvailable = !_context.Reservations
                .Any(r => r.Device_Id == deviceId &&
                         ((startDate >= r.Reserve_Start && startDate <= r.Reserve_End) ||
                          (endDate >= r.Reserve_Start && endDate <= r.Reserve_End) ||
                          (startDate <= r.Reserve_Start && endDate >= r.Reserve_End)));

            if (!isAvailable)
            {
                return Json(new { success = false, message = "Thiết bị đã được đặt trong khoảng thời gian này" });
            }

            // Tạo đơn đặt mới
            var reservation = new Reservations
            {
                Device_Id = deviceId,
                User_Id = userId.Value,
                Reserve_Start = startDate,
                Reserve_End = endDate,
                Status = "pending"
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return Json(new { success = true, message = "Đặt thiết bị thành công" });
        }

        [HttpPost]
        public IActionResult CancelBooking(int bookingId)
        {
            // Kiểm tra đăng nhập
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
            {
                return Json(new { success = false, message = "Vui lòng đăng nhập để thực hiện thao tác này" });
            }

            // Tìm phiếu đặt chỗ
            var booking = _context.Reservations
                .FirstOrDefault(r => r.Reservations_Id == bookingId && r.User_Id == userId);

            if (booking == null)
            {
                return Json(new { success = false, message = "Không tìm thấy phiếu đặt chỗ" });
            }

            // Kiểm tra trạng thái phiếu đặt chỗ
            if (booking.Status != "pending")
            {
                return Json(new { success = false, message = "Chỉ có thể hủy phiếu đặt chỗ đang ở trạng thái chờ duyệt" });
            }

            // Xóa phiếu đặt chỗ
            _context.Reservations.Remove(booking);
            _context.SaveChanges();

            return Json(new { success = true, message = "Hủy đặt chỗ thành công" });
        }
    }
} 