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
                new BookModel(){Id=1,Title="MVC",Author="Nitish",Description="This is MVC book",Category="Pattern",TotalPage=1200,Language="Bengali"},
                new BookModel(){Id=2,Title="C#",Author="Rakib",Description="This is C# book",Category="Programming",TotalPage=120,Language="English"},
                new BookModel(){Id=3,Title="JAVA",Author="Sakib",Description="This is JAVA book",Category="Programming",TotalPage=385,Language="Arabic"},
                new BookModel(){Id=4,Title="Python",Author="Raiyan",Description="This is Python book",Category="Programming",TotalPage=145,Language="Bengali"},
                new BookModel(){Id=5,Title="C++",Author="Shishir",Description="This is C++ book",Category="Programming",TotalPage=333,Language="Bengali"}
            };
        }
    }
}
