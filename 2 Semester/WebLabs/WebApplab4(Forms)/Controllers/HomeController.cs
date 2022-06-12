using Microsoft.AspNetCore.Mvc;
using WebApplab4_Forms_.Models;

namespace WebApplab4_Forms_.Controllers
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
            if (HttpContext.Session.Keys.Contains("user"))
            {
                User? user = HttpContext.Session.Get<User>("user");
            }
            else
            {
                User user = new User();
                HttpContext.Session.Set<User>("user", user);
            }

            return View();
        }

        public IActionResult Controls()
        {
            if (!HttpContext.Session.Keys.Contains("controls"))
            {
                Controls controls = new Controls();
                HttpContext.Session.Set<Controls>("controls", controls);
            }

            return View();
        }

        public IActionResult SignUpCredentials()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TextBox()
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    if (controls.textBox != "")
                    {
                        ViewBag.result = controls.textBox;
                        return View("TextBoxResult");
                    }
                    else
                    {
                        return View("TextBox");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpPost]
        public IActionResult TextBox(string textBox)
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    controls.textBox = textBox;
                    HttpContext.Session.Set<Controls>("controls", controls);
                    ViewBag.result = controls.textBox;

                    return View("TextBoxResult");
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpGet]
        public IActionResult TextArea()
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    if (controls.textArea != "")
                    {
                        ViewBag.result = controls.textArea;
                        return View("TextAreaResult");
                    }
                    else
                    {
                        return View("TextArea");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }
        [HttpPost]
        public IActionResult TextArea(string textArea)
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");
                //Show result page

                if (ModelState.IsValid && controls != null)
                {
                    controls.textArea = textArea;
                    HttpContext.Session.Set<Controls>("controls", controls);
                    ViewBag.result = controls.textArea;

                    //Show result
                    return View("TextAreaResult");
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpGet]
        public IActionResult CheckBox()
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    if (controls.checkBox != "")
                    {
                        ViewBag.result = controls.checkBox;
                        return View("CheckBoxResult");
                    }
                    else
                    {
                        return View("CheckBox");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpPost]
        public IActionResult CheckBox(string checkBox)
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    controls.checkBox = checkBox;
                    HttpContext.Session.Set<Controls>("controls", controls);
                    ViewBag.result = controls.checkBox;

                    return View("CheckBoxResult");
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpGet]
        public IActionResult Radio()
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    if (controls.radio != "")
                    {
                        ViewBag.result = controls.radio;
                        return View("RadioResult");
                    }
                    else
                    {
                        return View("Radio");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpPost]
        public IActionResult Radio(string radio)
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    controls.radio = radio;
                    HttpContext.Session.Set<Controls>("controls", controls);
                    ViewBag.result = controls.radio;

                    return View("RadioResult");
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpGet]
        public IActionResult DropDownList()
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    if (controls.dropDownList != "")
                    {
                        ViewBag.result = controls.dropDownList;
                        return View("DropDownListResult");
                    }
                    else
                    {
                        return View("DropDownList");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpPost]
        public IActionResult DropDownList(string dropDownList)
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    controls.dropDownList = dropDownList;
                    HttpContext.Session.Set<Controls>("controls", controls);
                    ViewBag.result = controls.dropDownList;

                    return View("DropDownListResult");
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpGet]
        public IActionResult ListBox()
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls != null)
                {
                    if (controls.listBox != "")
                    {
                        ViewBag.result = controls.listBox;
                        return View("ListBoxResult");
                    }
                    else
                    {
                        return View("ListBox");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpPost]
        public IActionResult ListBox(string listBox)
        {
            if (HttpContext.Session.Keys.Contains("controls"))
            {
                Controls? controls = HttpContext.Session.Get<Controls>("controls");

                if (ModelState.IsValid && controls!= null)
                {
                    controls.listBox = listBox;
                    HttpContext.Session.Set<Controls>("controls", controls);
                    ViewBag.result = controls.listBox;

                    return View("ListBoxResult");
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to controls menu for new data storage generation!");
            }
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            if (HttpContext.Session.Keys.Contains("user"))
            {
                User? user = HttpContext.Session.Get<User>("user");

                if (ModelState.IsValid && user != null)
                {
                    if (user.RegistrationStage == 1)
                    {
                        return View("SignUp1");
                    }
                    else if (user.RegistrationStage == 2)
                    {
                        return View("SignUp2");
                    }
                    else
                    {
                        ViewBag.firstName = user.firstName;
                        ViewBag.lastName = user.lastName;
                        ViewBag.birthDay = user.birthDay;
                        ViewBag.gender = user.gender;
                        ViewBag.email = user.email;
                        ViewBag.password = user.password;
                        return View("SignUpCredentials");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to index menu for new data storage generation!");
            }
        }

        [HttpPost]
        public IActionResult SignUp(Registration registration)
        {
            if (HttpContext.Session.Keys.Contains("user"))
            {
                User? user = HttpContext.Session.Get<User>("user");

                if ((registration.firstName != "" || registration.email != "") && user != null)
                {
                    if (user.RegistrationStage <= 2)
                    {
                        if (user.RegistrationStage == 1)
                        {
                            user.firstName = registration.firstName;
                            user.lastName = registration.lastName;

                            string birthString = "";
                            birthString += registration.birthDay;
                            birthString += " ";
                            birthString += registration.birthMonth;
                            birthString += " ";
                            birthString += registration.birthYear;

                            user.birthDay = birthString;
                            user.gender = registration.gender;
                            user.RegistrationStage++;

                            HttpContext.Session.Set<User>("user", user);
                            return View("SignUp2");
                        }
                        else
                        {
                            user.email = registration.email;
                            user.password = registration.password;
                            user.RegistrationStage++;

                            HttpContext.Session.Set<User>("user", user);

                            ViewBag.firstName = user.firstName;
                            ViewBag.lastName = user.lastName;
                            ViewBag.birthday = user.birthDay;
                            ViewBag.gender = user.gender;
                            ViewBag.email = user.email;
                            ViewBag.password = user.password;
                            return View("SignUpCredentials");
                        }

                    }
                    else
                    {
                        ViewBag.firstName = user.firstName;
                        ViewBag.lastName = user.lastName;
                        ViewBag.birthday = user.birthDay;
                        ViewBag.gender = user.gender;
                        ViewBag.email = user.email;
                        ViewBag.password = user.password;
                        return View("SignUpCredentials");
                    }
                }
                else
                {
                    return Content("Model is not valid!");
                }
            }
            else
            {
                return Content("Return to index menu for new data storage generation!");
            }
        }

        [HttpGet]
        public IActionResult PasswordReset()
        {
            if (HttpContext.Session.Keys.Contains("user"))
            {
                User? user = HttpContext.Session.Get<User>("user");
                if (user.firstName != "Not stated")
                return View("PasswordResetEmail");
                else
                {
                    return Content("No user data. Register first");
                }
            }
            else
            {
                return Content("Return to index menu! (No user presented in data)");
            }
        }

        [HttpPost]
        public IActionResult PasswordReset(string email, string code, string password)
        {
            if (email != null)
            {
                Random rand = new Random();
                string newCode = "";

                for (int i = 0; i < 10; i++)
                    newCode += rand.Next(0, 10).ToString();

                HttpContext.Session.SetString("newCode", newCode);
                ViewBag.testCode = newCode;
                ViewBag.error = "";

                return View("PasswordResetCode");
            }
            else if (code != null)
            {
                string newCode = "";
                newCode = HttpContext.Session.GetString("newCode");

                if (code == newCode)
                {
                    return View("PasswordReset");
                }
                else
                {
                    ViewBag.testCode = newCode;
                    ViewBag.error = "Invalid code";
                    return View("PasswordResetCode");
                }
            }
            else if (password != null)
            {
                if (HttpContext.Session.Keys.Contains("user"))
                {
                    User? user = HttpContext.Session.Get<User>("user");
                    if (user != null)
                    {
                        user.password = password;
                        HttpContext.Session.Set<User>("user", user);

                        ViewBag.message = "Password changed successfuly";
                        return View("Index");
                    }
                    else
                    {
                        return Content("Unknown error!");
                    }
                }
                else
                {
                    return Content("Error: user data is empty, register again!");
                }
            }
            else
            {
                return Content("Unknown error!");
            }
        }

    }
}