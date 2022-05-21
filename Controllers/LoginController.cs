using Microsoft.AspNetCore.Http;
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
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            return View();
        }
        public async Task<IActionResult> Cuenta() {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var response = await _db.GetStringAsync(Commons.Commons._URIUSERS_GETBYID+userid);
            if (response.Length < 0) return NotFound(response);
            var model = JsonConvert.DeserializeObject<UserModel>(response);
            return View(model);
        }
        public async Task<IActionResult> updateDesc(string desc)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEDESCRIPTION + userid + "/" + desc;
            var response = await _db.PutAsync(newUri,null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
     
        public async Task<IActionResult> updateMail(string mail)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEMAIL + userid + "/" + mail;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        public async Task<IActionResult> updateNick(string nick)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATENICK + userid + "/" + nick;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        public async Task<IActionResult> updatePassword(string password)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEPASS + userid + "/" + password;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        public async Task<IActionResult> updateAge(Int32 age)
        {
            if (age > 90) age = 0;
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEAGE + userid + "/" + age;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        //
        public async Task<IActionResult> updateFavm(string movie)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEAGE + userid + "/" + movie;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }
        public async Task<IActionResult> updateFava(string anime)
        {
            ViewData["token"] = HttpContext.Session.GetString("token");
            var userid = HttpContext.Session.GetString("id");
            var _db = new HttpClient();
            var newUri = Commons.Commons._URIUSERS_UPDATEAGE + userid + "/" + anime;
            var response = await _db.PutAsync(newUri, null);
            if (!response.IsSuccessStatusCode) return NotFound(response);
            return Ok();
        }

        public async Task<IActionResult> LoginAccess(string username,string password)
        {
            var _db = new HttpClient();
            var formatUser = username.Trim();
            var formatpass = password.Trim();
            var newUri = Commons.Commons._URILOGIN_LOGIN + "/" + formatUser + "/" + formatpass;
            var response = await _db.GetStringAsync(newUri);
            if(response.Length < 0 ) return NotFound(response);
            var model = JsonConvert.DeserializeObject<LoginModel>(response);
            HttpContext.Session.SetString("token", model.token);
            HttpContext.Session.SetString("id", model.id);
            return Ok();
        }
    }
}
