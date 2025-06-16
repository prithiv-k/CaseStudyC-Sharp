using Microsoft.AspNetCore.Mvc;
using ValidationUsingDataAnnotation.Models;

namespace BookModelvalidation.Controllers
{
    [Route("Book")]
    public class BookController : Controller
    {
        public static List<Book> books = new List<Book>
        {
            new Book
            {
                Isbn = 1,
                BookName = "HarryPotter",
                AuthorName = "JK Rowling",
                PublishedDate = new DateTime(2020, 1, 1),
                BookUrl = "www.hp.com"
            }
        };

        [Route("/")]
        [Route("List", Name = "List")]
        public IActionResult BookList()
        {
            return View(books);
        }

        [HttpGet]
        [Route("AddBook", Name = "AddBook")]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [Route("SaveBook", Name = "SaveBook")]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                books.Add(book);
                return RedirectToRoute("List");
            }

            return View("AddBook", book);
        }
    }
}
