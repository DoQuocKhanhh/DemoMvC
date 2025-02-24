using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models; // Đảm bảo đúng namespace
using System.Collections.Generic;

namespace DemoMvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, FullName = "Nguyễn Văn A" },
                new Student { Id = 2, FullName = "Trần Thị B" }
            };

            return View(students); // Truyền danh sách vào View
        }
    }
}
