using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Services
{
    public interface IBookService
    {
        public Task<BookResults> GetBook(string bookName);

        public Book GetUserBook(string name);

        public List<Book> GetAllUserBook();

        public Task<Book> SaveBook(string name);
    }
}
