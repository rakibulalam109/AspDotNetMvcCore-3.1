using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.BookStore.Models;
using WebApplication.BookStore.Repository;

namespace WebApplication.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data=_bookRepository.GetAllBooks();
            return View(data);
        }
        public ViewResult GetBookById(int id)
        {
            var data =  _bookRepository.GetBookById(id);
            return View(data);
        }
        public ViewResult SearchBook(string title,string author)
        {
             _bookRepository.SearchBook(title,author);
            return View();
        }
        public ViewResult AddNewBook()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            return View();
        }
    }
}
