using Buoi1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ShowKQ(Student sv)
        {
            Student.DanhSachSV.Add(sv);

            int soLuong = Student.DanhSachSV.Count(s => s.ChuyenNganh == sv.ChuyenNganh);
            ViewBag.MSSV = sv.MSSV;
            ViewBag.HoTen = sv.HoTen;
            ViewBag.ChuyenNganh = sv.ChuyenNganh;
            ViewBag.SoLuong = soLuong;

            return View();
        }
    }
}
