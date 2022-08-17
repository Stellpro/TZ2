using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TZ1.Data.Services
{
    public class GetCountry
    {
       public async Task<string> GetCountryList()
        {
            using var client = new HttpClient();
            var x = await client.GetAsync("https://restcountries.com/v2/all");
            //x.EnsureSuccessStatusCode();x.Wait();
            var content = await x.Content.ReadAsStringAsync();
            return content;
        }
    }
}
