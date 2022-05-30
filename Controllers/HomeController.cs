using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using xiaelappc.Models;

namespace xiaelappc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            return View();
        }
        public IActionResult Privacy()
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> GetEvents() {
            var lsEvents = new List<EventModel>();
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIMOVIES_GETALLMOVIES);
            if (response.Length < 0) return NotFound();
            var model = JsonConvert.DeserializeObject<List<MovieModel>>(response);
            if (model == null) return NotFound();
            foreach(var m in model)
            {
                lsEvents.Add(new EventModel{ 
                    Title = m.titulo,
                    Start = m.lanzamiento,
                    End = m.lanzamiento
                });
            }
            return Ok(lsEvents.ToArray());
        }
    }
}
