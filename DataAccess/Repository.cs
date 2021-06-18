using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class Repository : IRepository
    {
        private DataContext _dataContext;
        public Repository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public Book FindBook(string name)
        {
            Book foundBook = _dataContext.Books.Where(book => book.Title == name).FirstOrDefault();
            return foundBook;
        }

        public List<Book> GetAll()
        {
            return _dataContext.Books.ToList();
        }

        public async Task Save(Book book)
        {
            await _dataContext.Books.AddAsync(book);
            await _dataContext.SaveChangesAsync();
        }
    }
}
