using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        [JsonProperty("docs")]
        public IEnumerable<Book> Books { get; set; }
    

    
    }
}
