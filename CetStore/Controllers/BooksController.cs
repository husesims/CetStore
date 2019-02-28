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
        List<Book> books = new List<Book>();
        public BooksController()
        {
            Book book1 = new Book();
            book1.Id = 1;
            book1.Name = "CET 301";
            book1.Price = 99.99M;
            books.Add(book1);
            Book book2 = new Book();
            book2.Id = 2;
            book2.Name = "C# ve Veritabanı";
            book2.Price = 199.99M;
            books.Add(book2);

        }
        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Detay(int id)
        {
            Book book = new Book();
            if (id == 1)
            {
                book = books[0];
            } else if (id==2) {
                book = books[1];
            } else
            {
                return NotFound();
            }
            return View(book);
        }
    }
}