using Microsoft.AspNetCore.Mvc;
using WebMinimalAppLab.Models;

namespace WebMinimalAppLab.Controllers
{
    public class CalculationsController : Controller
    {
        public IActionResult UsingInjection()
        {
            return View();
        }
        public IActionResult UsingDataBag()
        {
            ViewBag.Calcululus = new Calculation();
            return View();
        }

        public IActionResult UsingViewData()
        {
            ViewData["Calc"] = new Calculation();
            return View();
        }

        public IActionResult UsingModel()
        {
            var Calc = new Calculation();
            return View(Calc);
        }
    }
}
