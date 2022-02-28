using Microsoft.AspNetCore.Mvc;
using WebMinimalAppLab.Models;

namespace WebMinimalAppLab.Controllers
{
    public class CalculationsController : Controller
    {
        private readonly ICalculateService Icalcus;
        public CalculationsController(ICalculateService Ic)
        {
            Icalcus = Ic;
        }
        public IActionResult UsingInjection()
        {
            ViewBag.Sum = Icalcus.Sum();
            ViewBag.Sub = Icalcus.Sub();
            ViewBag.Mul = Icalcus.Mul();
            ViewBag.Div = Icalcus.Div();
            ViewBag.ValueOne = Icalcus.GetValueOne();
            ViewBag.ValueTwo = Icalcus.GetValueTwo();
            ViewBag.Error = Icalcus.GetError();

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

        public IActionResult Index()
        {
            var Calc = new Calculation();
            return View(Calc);
        }
    }
}
