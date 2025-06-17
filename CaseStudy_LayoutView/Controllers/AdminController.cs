using CaseStudy_LayoutView.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy_LayoutView.Controllers
{
    [Route("Admin")]
    public class AdminController : Controller
    {
        [Route("Dashboard")]
        public IActionResult Dashboard()
        {
            if (!IsAuthorized(UserRole.Admin))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [Route("UpdateProfile")]
        public IActionResult UpdateProfile()
        {
            if (!IsAuthorized(UserRole.Admin))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [Route("ManageCourses")]
        public IActionResult ManageCourses()
        {
            if (!IsAuthorized(UserRole.Admin))
                return RedirectToAction("Login", "Home");

            var courses = GetCourses(); // Mock data
            return View(courses);
        }

        [Route("AddCourse")]
        public IActionResult AddCourse()
        {
            if (!IsAuthorized(UserRole.Admin))
                return RedirectToAction("Login", "Home");

            return View();
        }

        [HttpPost]
        [Route("AddCourse")]
        public IActionResult AddCourse(Course course)
        {
            if (!IsAuthorized(UserRole.Admin))
                return RedirectToAction("Login", "Home");

            if (ModelState.IsValid)
            {
                // Add course logic here
                return RedirectToAction("ManageCourses");
            }
            return View(course);
        }

        [Route("ManageTrainers")]
        public IActionResult ManageTrainers()
        {
            if (!IsAuthorized(UserRole.Admin))
                return RedirectToAction("Login", "Home");

            var trainers = GetTrainers(); // Mock data
            return View(trainers);
        }

        [Route("ManageLearners")]
        public IActionResult ManageLearners()
        {
            if (!IsAuthorized(UserRole.Admin))
                return RedirectToAction("Login", "Home");

            var learners = GetLearners(); // Mock data
            return View(learners);
        }

        private bool IsAuthorized(UserRole requiredRole)
        {
            var userRole = HttpContext.Session.GetString("Role");
            return userRole == requiredRole.ToString();
        }

        private List<Course> GetCourses()
        {
            return new List<Course>
            {
                new Course { Id = 1, Name = "C# Fundamentals", Description = "Learn C# basics", Duration = 40 },
                new Course { Id = 2, Name = "ASP.NET Core MVC", Description = "Web development with MVC", Duration = 60 }
            };
        }

        private List<User> GetTrainers()
        {
            return new List<User>
            {
                new User { Id = 1, Username = "trainer1", FullName = "John Trainer", Email = "john@example.com", Role = UserRole.Trainer }
            };
        }

        private List<User> GetLearners()
        {
            return new List<User>
            {
                new User { Id = 1, Username = "learner1", FullName = "Jane Learner", Email = "jane@example.com", Role = UserRole.Learner }
            };
        }
    }
}
