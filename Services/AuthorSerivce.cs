using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Library.Services
{
    public class AuthorSerivce : IAuthorService
    {
        private HttpClient _client;
        private const string API = "http://openlibrary.org/search.json?";
        public AuthorSerivce(HttpClient client)
        {
            this._client = client;
        }

        public async Task<Author> GetAuthor(string authorName)
        {
            Author author = null;
            string path = $"{API}author={authorName}";
            
            HttpResponseMessage response = await _client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                author = await response.Content.ReadAsAsync<Author>();
                author.AuthorName = authorName;
            }
            return author;
        }

            
    
    }
}
