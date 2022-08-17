using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TZ1.Data.Models
{
    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }
        // public virtual Details Details { get; set; }

    }
}
