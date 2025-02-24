using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class BillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(BillCalculator model)
        {
            if (model.Quantity > 0 && model.UnitPrice > 0)
            {
                ViewBag.Total = model.Total;
            }
            return View("Index");
        }
    }
}
