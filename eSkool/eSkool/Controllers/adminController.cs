using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using eSkool.Models;
using System.Collections.Generic;
using System.Linq;

namespace eSkool.Controllers
{
    public class adminController : Controller
    {

        public IActionResult adminDashboard()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using(eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;
                        ViewBag.color = "57%";

                        //Coding Block---------------------------------------------------------
                        {
                            return View();
                        }
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }
                
            }
            return RedirectToAction("login", "login");
   
        }


        [HttpGet]
        public IActionResult addTeacher()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {

                        return View();
                        }
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
            
        }




        [HttpPost]
        public IActionResult addTeacher(string tId,string userName,string salary,string designation,string password)
        {
           if(HttpContext.Session.GetString("username") != null)
            {
                string role = "T";
                try
                {
                    using (eSkoolDBContext dBContext = new eSkoolDBContext())
                    {
                        UserInfo temp = new UserInfo();
                        temp.UserName = userName;
                        temp.Password = password;
                        temp.Role = role;
                        dBContext.UserInfos.Add(temp);
                        dBContext.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    
                }
                return RedirectToAction("addUsers", "admin");
            }
           return RedirectToAction("login", "login");
        }



        public IActionResult showTeachers()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {

                        return View();
                        }
                        //Coding Block---------------------------------------------------------
                    
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");          
        }




        [HttpGet]
        public IActionResult addStudent()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {


                            return View();
                        }
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");            
        }
        [HttpPost]
        public IActionResult addStudent(string sId, string userName, string rollnum, string sClass, string password)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string role = "S";
                try
                {
                    using (eSkoolDBContext dBContext = new eSkoolDBContext())
                    {
                        UserInfo temp = new UserInfo();
                        temp.UserName = userName;
                        temp.Password = password;
                        temp.Role = role;
                        dBContext.UserInfos.Add(temp);
                        dBContext.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    
                }
                return RedirectToAction("addUsers", "admin");
            }
            return RedirectToAction("login", "login");
        }

        public IActionResult showStudents()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {

                            return View();
                        }
                        //Coding Block---------------------------------------------------------
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
         
        }



        [HttpGet]
        public IActionResult addQuestion()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {


                            return View();
                        }
                        //Coding Block---------------------------------------------------------

                       
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");            
        }


        [HttpPost]
        public IActionResult addQuestion(string Syllabus,string Class,string Questiontype,string Subject,string Chapter,
            string Exercise,string Statement,string Option1=null, string Option2=null, string Option3=null, string Option4=null, string CorrectOption=null)
        {
            return View();
        }


        public IActionResult questionNotification()
        {

            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {

                            return View();
                        }
                        //Coding Block---------------------------------------------------------

                       
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
        }



        [HttpGet]
        public IActionResult addClass()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                   
                    if (role == "A")
                    {
                       ViewBag.username = username;
                       
                         //Coding Block--------------------------------------------
                        {
                            List<UserInfo> Teachers = null;
                            try
                            {
                                using (eSkoolDBContext eskoolDb = new eSkoolDBContext())
                                {
                                    Teachers = eskoolDb.UserInfos.ToList();

                                }
                            }
                            catch (Exception e)
                            {

                            }

                            return View(Teachers);
                        }
                        //Coding Block-----------------------------------------------------
                    }


                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }
            }
            return RedirectToAction("login", "login");
                       
        }



        [HttpPost]
        public IActionResult addClass(string className,string grade,string teacherName,int strength)
        {
            return View();
        }



        public IActionResult showClasses()
        {

            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "A")
                    {
                        ViewBag.username = username;

                        //Coding Block------------------------------------------------------------
                        {
                            List<UserInfo> Teachers = null;
                            try
                            {
                                using (eSkoolDBContext eskoolDb = new eSkoolDBContext())
                                {
                                    Teachers = eskoolDb.UserInfos.ToList();

                                }
                            }
                            catch (Exception e)
                            {

                            }

                            return View(Teachers);
                        }
                        //Coding Block--------------------------------------------------------
                    
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");                       
        }

    }
}
