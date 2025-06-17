using CaseStudy_LayoutView.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy_LayoutView.Controllers
{
    [Route("Trainer")]
    public class TrainerController : Controller
    {
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            if (!IsAuthorized(UserRole.Trainer))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [Route("UpdateProfile")]
        public IActionResult UpdateProfile()
        {
            if (!IsAuthorized(UserRole.Trainer))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [Route("ManageContent")]
        public IActionResult ManageContent()
        {
            if (!IsAuthorized(UserRole.Trainer))
                return RedirectToAction("Login", "Home");

            var content = GetContent(); // Mock data
            return View(content);
        }

        [Route("AddContent")]
        public IActionResult AddContent()
        {
            if (!IsAuthorized(UserRole.Trainer))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [HttpPost]
        [Route("AddContent")]
        public IActionResult AddContent(Content content)
        {
            if (!IsAuthorized(UserRole.Trainer))
                return RedirectToAction("Login", "Home");

            if (ModelState.IsValid)
            {
                // Add content logic here
                return RedirectToAction("ManageContent");
            }
            return View(content);
        }

        private bool IsAuthorized(UserRole requiredRole)
        {
            var userRole = HttpContext.Session.GetString("Role");
            return userRole == requiredRole.ToString();
        }

        private List<Content> GetContent()
        {
            return new List<Content>
            {
                new Content { Id = 1, Title = "Variables in C#", Description = "Introduction to variables", CourseId = 1 },
                new Content { Id = 2, Title = "MVC Pattern", Description = "Understanding MVC", CourseId = 2 }
            };
        }
    }
}
