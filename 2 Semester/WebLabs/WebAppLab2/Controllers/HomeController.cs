using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppLab2.Models;

namespace WebAppLab2.Controllers
{
    public class HomeController : Controller
    {


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Manual()
        {

            return View();
        }

        public IActionResult ManualWithSeparateHandlers()
        {
            return View();
        }


        public ViewResult Result(int answer, int a, int b, string operation)
        {
            ViewBag.Answer = answer;
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Operation = operation;
            return View();
        }

        [HttpGet]
        public ViewResult ModelBindingInSeparateModel()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult ModelBindingInSeparateModel(Calculator calc)
        {
            return RedirectToAction("Result", new {answer = calc.Calculate(), 
            a = calc.numberOne, b = calc.numberTwo, operation = calc.operation});
        }

        [HttpGet]
        public ViewResult ModelBindingInParameters()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult ModelBindingInParameters(int numberOne, int numberTwo, string operation)
        {
            var solution = 0;
            if (operation == "+")
                solution = numberOne + numberTwo;
            else if (operation == "-")
                solution = numberOne - numberTwo;
            else if (operation == "*")
                solution = numberOne * numberTwo;
            else if (operation == "/")
                solution = numberOne / numberTwo;

            return RedirectToAction("Result", new {answer = solution, 
            a = numberOne, b = numberTwo, operation = operation});
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}