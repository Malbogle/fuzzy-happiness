using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        [JsonProperty("title")]
        public string Title { get; set; }


        [JsonProperty("first_publish_year")]
        public int FirstPublishYear { get; set; }

        [JsonProperty("authors_names")]
        public List<string> AuthorsName { get; set; }

        [JsonIgnore]
        public List<User> UsersBooks { get; set; }



    }
}
