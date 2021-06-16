using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
       
        [Required]
        [MaxLength(200)]
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }
        
        [JsonProperty("books")]
        public List<Book> UsersBooks { get; set; } = new List<Book>();
    
    }
}
