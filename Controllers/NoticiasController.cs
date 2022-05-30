using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiaelappc.Controllers
{
    public class NoticiasController : Controller
    {
        public IActionResult Index()
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            return View();
        }
    }
}
