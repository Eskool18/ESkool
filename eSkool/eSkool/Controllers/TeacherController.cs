using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSkool.Logistics;
using Microsoft.AspNetCore.Http;
namespace eSkool.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Dashboard()
        {
            ActiveUser.recordActive( HttpContext.Session.GetString("username"));
            return View();
        }
        public IActionResult setPaper()
        {
            ActiveUser.recordActive(HttpContext.Session.GetString("username"));
            return View();
        }


    }
}
