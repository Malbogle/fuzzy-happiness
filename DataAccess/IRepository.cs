using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public interface IRepository
    {
        Task Save(Book book);
        List<Book> GetAll();

        Book FindBook(string name);
    
    }
}
