using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class BMIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(BMICalculator model)
        {
            if (model.Weight > 0 && model.Height > 0)
            {
                float bmi = model.BMI;
                string message = bmi switch
                {
                    < 18.5f => "Bạn bị thiếu cân!",
                    >= 18.5f and < 24.9f => "Bạn có cân nặng bình thường!",
                    >= 25 and < 29.9f => "Bạn bị thừa cân!",
                    _ => "Bạn bị béo phì!"
                };

                ViewBag.BMI = bmi;
                ViewBag.Message = message;
            }
            return View("Index");
        }
    }
}
