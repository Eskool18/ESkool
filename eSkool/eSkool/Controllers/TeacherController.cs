using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSkool.Logistics;
using eSkool.Models;
using Microsoft.AspNetCore.Http;
namespace eSkool.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "T")
                    {
                        ViewBag.username = username;
                        ActiveUser.recordActive(username);
                        //Coding Block---------------------------------------------------------
                        {
                            bool inchargeStatus = db.SchoolClasses.Where(x => x.Incharge == username).SingleOrDefault() != null;
                            ViewBag.InchargeStatus = inchargeStatus;
                            return View();
                        }
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login"); ;
        }
        public IActionResult setPaper()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "T")
                    {
                        ViewBag.username = username;
                        ActiveUser.recordActive(username);
                        //Coding Block---------------------------------------------------------
                        {
                            return View();
                        }
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login"); ;
        }

        [HttpGet]
        public IActionResult markAttendence()
        {

            {
                if (HttpContext.Session.GetString("username") != null)
                {
                    string username = HttpContext.Session.GetString("username");
                    ActiveUser.recordActive(username);

                    try
                    {
                        using (eSkoolDBContext dBContext = new eSkoolDBContext())
                        {

                            string className = dBContext.SchoolClasses.Where(x => x.Incharge == username).SingleOrDefault().ClassName;
                            List<Student> studentList = dBContext.Students.Where(x=> x.ClassName == className).ToList();
                            ViewBag.date = DateTime.Now.ToLongDateString();

                            return View(studentList);


                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    return RedirectToAction("showStudents", "admin");
                }
                return RedirectToAction("login", "login");


            }
        }
    }
}
