using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
    using System.Net.Http;
using Library.DataAccess;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private HttpClient _client;
        private IRepository _repository;
        private const string API = "http://openlibrary.org/search.json?";

        public BookService(IRepository repository,HttpClient client)
        {
            this._repository = repository;
            this._client = client;
        }
        public async Task<BookResults> GetBook(string bookName) //To do stuff async, need to wrap in a task
        {
            BookResults book = null;
            string path = $"{API}title={bookName}";

            HttpResponseMessage response = await _client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                book = await response.Content.ReadAsAsync<BookResults>();        
            }
            return book;

        }
        public async Task<Book> SaveBook(string name)
        {
            BookResults bookResult = await GetBook(name);
            Book bookToSave = bookResult.BooksList.Where(book => book.Title.ToLower() == name.ToLower()).FirstOrDefault();
            await _repository.Save(bookToSave);
            return bookToSave;
        }


        public Book GetUserBook(string name)
        {
            return _repository.FindBook(name);
        }

        public List<Book> GetAllUserBook()
        {
            return _repository.GetAll();
        }

 
    }
}
