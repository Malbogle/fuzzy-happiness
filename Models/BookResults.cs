using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Library.Models
{
    public class BookResults
    {

        [JsonProperty("docs")]
        public List<Book> BooksList { get; set; }
    }
}
