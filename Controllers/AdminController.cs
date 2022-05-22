using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using xiaelappc.Models;
using Newtonsoft.Json;

namespace xiaelappc.Controllers
{
    public class AdminController : Controller
    {
        public async Task<IActionResult> AdminPanel()
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var res = await _db.GetStringAsync(Commons.Commons._URIUSERS_GETALLUSERS);
            if (res == null) return BadRequest();
            var model = JsonConvert.DeserializeObject<List<UserModel>>(res);
            return PartialView("_AdminPV",model);
        }
    }
}
