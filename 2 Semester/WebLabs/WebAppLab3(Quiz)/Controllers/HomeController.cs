using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppLab3_Quiz_.Models;

namespace WebAppLab3_Quiz_.Controllers
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
            if (HttpContext.Session.Keys.Contains("Quiz"))
            {
            }
            else
            {
                Quiz quiz = new Quiz();
                HttpContext.Session.Set<Quiz>("Quiz", quiz);
            }

            return View();
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            if (HttpContext.Session.Keys.Contains("Quiz"))
            {
                Quiz? quiz = HttpContext.Session.Get<Quiz>("Quiz");
                if (quiz.finished == true)
                {
                    quiz.StartQuiz();
                    HttpContext.Session.Set<Quiz>("Quiz", quiz);
                }

                if (ModelState.IsValid && quiz != null)
                {
                    if (quiz.curQuestion == quiz.questNumber)
                    {
                        return RedirectToAction("ShowQuizResult");
                    }
                    else
                    {
                        ViewBag.question = quiz.NextQuestion();
                        return View();
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to main menu for new quiz generation!");
            }
        }

        [HttpPost]
        public IActionResult Quiz(WebAppLab3_Quiz_.Models.Answer ans)
        {
            if (HttpContext.Session.Keys.Contains("Quiz"))
            {
                Quiz? quiz = HttpContext.Session.Get<Quiz>("Quiz");
                quiz.userAnswer[quiz.curQuestion] = ans.answer.ToString();
                if (ans.answer == quiz.answer[quiz.curQuestion])
                {
                    quiz.corrects++;
                }
                quiz.curQuestion++;


                if (ModelState.IsValid && quiz != null)
                {
                    HttpContext.Session.Set<Quiz>("Quiz", quiz);

                    if (quiz.curQuestion == quiz.questNumber)
                    {
                        return RedirectToAction("ShowQuizResult");
                    }
                    else
                    {
                        ViewBag.question = quiz.NextQuestion();
                        return View();
                    }  
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to main menu for new quiz generation!");
            }
        }

        public IActionResult ShowQuizResult()
        {
            if (HttpContext.Session.Keys.Contains("Quiz"))
            {
                Quiz? quiz = HttpContext.Session.Get<Quiz>("Quiz");
                quiz.finished = true;


                if (ModelState.IsValid && quiz != null)
                {
                    HttpContext.Session.Set<Quiz>("Quiz", quiz);
                    ViewBag.result = quiz.ShowResults();
                    return View(quiz);
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Start quiz first");
            }
        }

        [HttpPost]
        public IActionResult ShowQuizResult(WebAppLab3_Quiz_.Models.Answer ans)
        {
            if (HttpContext.Session.Keys.Contains("Quiz"))
            {
                Quiz? quiz = HttpContext.Session.Get<Quiz>("Quiz");
                quiz.userAnswer[quiz.curQuestion] = ans.answer.ToString();
                if (ans.answer == quiz.answer[quiz.curQuestion])
                {
                    quiz.corrects++;
                }
                quiz.curQuestion++;
                quiz.finished = true;


                if (ModelState.IsValid && quiz != null)
                {
                    HttpContext.Session.Set<Quiz>("Quiz", quiz);
                    return RedirectToAction("ShowQuizResult");
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to main menu for new quiz generation!");
            }
        }

        public IActionResult Mockups()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}