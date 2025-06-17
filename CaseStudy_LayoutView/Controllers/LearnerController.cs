using CaseStudy_LayoutView.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy_LayoutView.Controllers
{
    [Route("Learner")]
    public class LearnerController : Controller
    {
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            if (!IsAuthorized(UserRole.Learner))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [Route("UpdateProfile")]
        public IActionResult UpdateProfile()
        {
            if (!IsAuthorized(UserRole.Learner))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [Route("SearchContent")]
        public IActionResult SearchContent(string searchTerm = "")
        {
            if (!IsAuthorized(UserRole.Learner))
                return RedirectToAction("Login", "Home");

            var content = GetAvailableContent(searchTerm);
            ViewBag.SearchTerm = searchTerm;
            return View(content);
        }

        private bool IsAuthorized(UserRole requiredRole)
        {
            var userRole = HttpContext.Session.GetString("Role");
            return userRole == requiredRole.ToString();
        }

        private List<Content> GetAvailableContent(string searchTerm = "")
        {
            var allContent = new List<Content>
            {
                new Content { Id = 1, Title = "Variables in C#", Description = "Introduction to variables", CourseId = 1 },
                new Content { Id = 2, Title = "MVC Pattern", Description = "Understanding MVC", CourseId = 2 },
                new Content { Id = 3, Title = "Entity Framework", Description = "Database operations", CourseId = 2 }
            };

            if (string.IsNullOrEmpty(searchTerm))
                return allContent;

            return allContent.Where(c => c.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                                       c.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                           .ToList();
        }
    }
}
