using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using TZ1.Data.Models;
using TZ1.Data.Services;

namespace TZ1.Data.Controller1
{
    [Route("/")]
    public class HomeController : Controller
    {
        private GetCountry _country = new GetCountry();
        [Route("/")]
        public async Task<ActionResult> Index()
        {
            var x = await _country.GetCountryList();
            var p = JsonConvert.DeserializeObject<List<Country>> (x);
            return View(p);
        }

        [Route("/Details/{country?}")]
        public async Task<ActionResult> Ditails(string country)
        {
            var x = await _country.GetCountryList();
            var p = JsonConvert.DeserializeObject<List<Details>>(x);
            var temp = p.Where(x => x.Name == country);
            return View(temp);
        }
        
        // GET: HomeController/Details/5
    }
}

