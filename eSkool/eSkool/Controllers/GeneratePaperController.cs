using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSkool.Controllers
{
    
    public class GeneratePaperController : Controller
    {
       static List<string> PageTraverse = new List<string>();
        public IActionResult showCourses()
        {
            return View();
        }

       [HttpGet]
        public IActionResult showClasses(string courseName)
        {
            PageTraverse.Add(courseName);
            ViewBag.name = courseName;
            
            return View(); 
        }

        public IActionResult showSubjects(int className)
        {

            PageTraverse.Add(className.ToString());
            ViewBag.className = className;
            ViewBag.name = PageTraverse.ElementAt(0);

            return View();
        }

        public IActionResult selectSyllabus(string subjectName)
        {
            PageTraverse.Add(subjectName);
            ViewBag.subjectName = subjectName;
            


            return View();
        }
    }
}
