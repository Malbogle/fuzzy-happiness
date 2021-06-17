using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
    using System.Net.Http;

namespace Library.Services
{
    public class BookService : IBookService
    {
        private HttpClient _client;
        private const string API = "http://openlibrary.org/search.json?";

        public BookService(HttpClient client)
        {
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
    }
}
