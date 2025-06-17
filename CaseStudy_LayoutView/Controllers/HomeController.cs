using CaseStudy_LayoutView.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy_LayoutView.Controllers
{
   
        public class HomeController : Controller
        {
            [Route("")]
            [Route("Home")]
            [Route("Home/Index")]
            public IActionResult Index()
            {
                return View();
            }

            [Route("About")]
            public IActionResult About()
            {
                return View();
            }

            [Route("Contact")]
            public IActionResult Contact()
            {
                return View();
            }

            [Route("Login")]
            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            [Route("Login")]
            public IActionResult Login(Login model)
            {
                if (ModelState.IsValid)
                {
                    // Simple authentication logic (in real app, use proper authentication)
                    if (ValidateUser(model))
                    {
                        // Set session or authentication cookie
                        HttpContext.Session.SetString("Username", model.Username);
                        HttpContext.Session.SetString("Role", model.Role.ToString());

                        // Redirect based on role
                        switch (model.Role)
                        {
                            case UserRole.Admin:
                                return RedirectToAction("Dashboard", "Admin");
                            case UserRole.Trainer:
                                return RedirectToAction("Dashboard", "Trainer");
                            case UserRole.Learner:
                                return RedirectToAction("Dashboard", "Learner");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid username or password");
                    }
                }
                return View(model);
            }

            [Route("AdminLogin")]
            public IActionResult AdminLogin()
            {
                var model = new Login { Role = UserRole.Admin };
                return View("Login", model);
            }

            [Route("TrainerLogin")]
            public IActionResult TrainerLogin()
            {
                var model = new Login { Role = UserRole.Trainer };
                return View("Login", model);
            }

            [Route("LearnerLogin")]
            public IActionResult LearnerLogin()
            {
                var model = new Login { Role = UserRole.Learner };
                return View("Login", model);
            }

            [Route("Logout")]
            public IActionResult Logout()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }

            private bool ValidateUser(Login model)
            {
                // Simple validation - in real app, check against database
                return !string.IsNullOrEmpty(model.Username) && !string.IsNullOrEmpty(model.Password);
            }
        }
    }

