using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSkool.Controllers
{
    public class GeneratePaperController : Controller
    {
        List<string> PageTraverse;

        public IActionResult showCourses()
        {
            return View();
        }

       [HttpGet]
        public IActionResult showClasses(string courseName)
        {
            //PageTraverse.Add(courseName);
            ViewBag.name = courseName;
            
            return View(); 
        }

        public IActionResult showSubjects()
        {
            return View();
        }
    }
}
