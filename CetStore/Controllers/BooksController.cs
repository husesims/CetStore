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
            if (ModelState.IsValid)
            {
                cetStoreContext.Books.Add(book);
                cetStoreContext.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View(book);
            }
        }
        public IActionResult Edit (int? id)
        {
            if(!id.HasValue)
            {
                return BadRequest();
            }
            var book = cetStoreContext.Books.Find(id);
            if(book==null)
            {
                return NotFound();
            }

            return View(book);

            
        }
        [HttpPost]
        public IActionResult Edit(int? id, Book book)
        {

            if (!id.HasValue)
            {
                return BadRequest();
            }
          
            if (book == null)
            {
                return NotFound();
            }

            if(id!=book.Id)
            {
                return BadRequest();
            }
            if (ModelState.IsValid)
            {
                cetStoreContext.Books.Update(book);
                cetStoreContext.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View(book);
            }
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