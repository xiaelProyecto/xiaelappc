using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace xiaelappc.Controllers
{
    public class RegistroController : Controller
    {
       public async Task<IActionResult> Registro(string username,string password,string mail)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(mail)) return BadRequest();
            var newUri = Commons.Commons._URIUSERS_CREATEUSER + username + "/" + password + "/" + mail;
            var _db = new HttpClient();
            var res = await _db.PostAsync(newUri,null);
            if (!res.IsSuccessStatusCode) return BadRequest(res.RequestMessage);

            return Ok();
        }
    }
}
