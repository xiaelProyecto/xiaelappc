using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xiaelappc.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace xiaelappc.Controllers
{
    public class AnimeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIANIME_GETALLANIMES);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<List<AnimeModel>>(response);
            return View(model);
            
        }
        public async Task<ActionResult> FichaAnime(string id)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIANIME_GETANIMEBYID + id);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<AnimeModel>(response);

            return View(model);
        }
        public async Task<ActionResult> PVFichaAnime(string name)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIANIME_GETBYNAME + name);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<AnimeModel>(response);
            return PartialView("_FichaAnimeModal", model);
        }

    }
}
