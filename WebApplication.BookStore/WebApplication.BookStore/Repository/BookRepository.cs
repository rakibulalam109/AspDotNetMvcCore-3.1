using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.BookStore.Models;

namespace WebApplication.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title,string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Nitish"},
                new BookModel(){Id=2,Title="C#",Author="Rakib"},
                new BookModel(){Id=3,Title="JAVA",Author="Sakib"}
            };
        }
    }
}
