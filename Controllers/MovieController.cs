using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIMOVIES_GETALLMOVIES);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<List<MovieModel>>(response);
            return View(model);
        }

        public async Task<ActionResult> FichaPelicula(string id)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIMOVIES_GETBYID+id);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<MovieModel>(response);
            
            return View(model);
        }

        public async Task<ActionResult> PVFichaPelicula(string name)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIMOVIES_GETBYNAME + name);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<MovieModel>(response);
            return PartialView("_FichaPeliculaModal",model);
        }

    }
}
