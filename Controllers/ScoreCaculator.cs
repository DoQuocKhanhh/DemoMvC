using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class ScoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(ScoreCalculator model)
        {
            float avg = model.Average;
            string grade = avg switch
            {
                >= 9 => "Xuất sắc",
                >= 8 => "Giỏi",
                >= 7 => "Khá",
                >= 5 => "Trung bình",
                _ => "Yếu"
            };

            ViewBag.Average = avg;
            ViewBag.Grade = grade;

            return View("Index");
        }
    }
}
