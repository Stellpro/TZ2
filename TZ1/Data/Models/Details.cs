
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZ1.Data.Models
{
    public class Details
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
        [JsonProperty("capital")]
        public string Capital { get; set; }
        [JsonProperty("languages")]
        public Language [] Languages { get; set; }

    }
    public partial class Language
    {
        [JsonProperty("iso639_1", NullValueHandling = NullValueHandling.Ignore)]
        public string Iso6391 { get; set; }

        [JsonProperty("iso639_2")]
        public string Iso6392 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nativeName", NullValueHandling = NullValueHandling.Ignore)]
        public string NativeName { get; set; }
    }
}
