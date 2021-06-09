using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("first_publish_year")]
        public int FirstPublishYear { get; set; }
        [JsonProperty("isbn")]
        public IEnumerable<string> ISBN { get; set; }

    }
}
