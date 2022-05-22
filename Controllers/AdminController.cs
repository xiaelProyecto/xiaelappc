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

        public async Task<IActionResult> deleteUser(string id)
        {
            var _db = new HttpClient();
            var res = await _db.DeleteAsync(Commons.Commons._URIUSERS_DELETE+id);
            if (!res.IsSuccessStatusCode) return NotFound();
            return Ok();
        }

        public async Task<IActionResult> FichaUsuario(string id)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var _db = new HttpClient();
            var res = await _db.GetStringAsync(Commons.Commons._URIUSERS_GETBYID+id);
            if (res == null) return BadRequest();
            var model = JsonConvert.DeserializeObject<UserModel>(res);
            return View(model);
        }

        public async Task<IActionResult> updateMail(string id,string mail)
        {
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEMAIL + id + "/" + mail;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        public async Task<IActionResult> updateNick(string id, string nick)
        {
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATENICK + id + "/" + nick;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        public async Task<IActionResult> updatePassword(string id,string password)
        {
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEPASS + id + "/" + password;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        public async Task<IActionResult> updateAge(string id,Int32 age)
        {
            if (age > 90) age = 0;
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEAGE + id + "/" + age;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
    }
}
