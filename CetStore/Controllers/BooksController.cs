using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CetStore.Models;
using Microsoft.AspNetCore.Mvc;

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