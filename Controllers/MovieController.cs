using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using xiaelappc.Models;

namespace xiaelappc.Controllers
{
    public class MovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIMOVIES);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<List<MovieModel>>(response);
            return View(model);
        }

        public async Task<ActionResult> FichaPelicula(string id)
        {
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIMOVIES+"/"+id);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<MovieModel>(response);
            
            return View(model);
        }


    }
}
