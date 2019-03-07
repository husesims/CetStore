using CetStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CetStore.Controllers
{
    public class BooksController : Controller
    {
        CetStoreContext cetStoreContext;

        public BooksController(CetStoreContext context)
        {
            cetStoreContext = context;

        }
        public IActionResult Index()
        {
            var books = cetStoreContext.Books.ToList();
            return View(books);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            cetStoreContext.Books.Add(book);
            cetStoreContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detay(int id)
        {
            
            Book book = cetStoreContext.Books.Where(b => b.Id == id).FirstOrDefault();
            if (book != null)
            {
                return View(book);
            } else
            {
                return NotFound();
            }
        }
    }
}