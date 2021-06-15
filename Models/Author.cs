using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        [JsonIgnore]
        private string _authorName;
        
        [JsonProperty("docs")]
        public IEnumerable<Book> Books { get; set; }
        [JsonProperty("authorName")]
      
        
        public string AuthorName
        {
            get
            {
                return this._authorName;
            }
            set
            {
                if(value != null)
                {
                    this._authorName = value.ToTitleCase();
                }
            }
        }
    
    }
}
