using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eSkool.Controllers
{
    public class Student : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public ActionResult download_books()
        {
            return View();
        }
    }
}
