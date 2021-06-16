using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Author
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        
        [MaxLength(200)]
        [JsonIgnore]
        private string _authorName;
        
        [JsonProperty("docs")]
        public List<Book> Books { get; set; }

        [MaxLength(200)]
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
