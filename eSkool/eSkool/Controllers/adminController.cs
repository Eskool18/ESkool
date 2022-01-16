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
                ViewBag.color = "57%";
                return View();
            }
            return RedirectToAction("login", "login");
   
        }


        [HttpGet]
        public IActionResult addTeacher()
        {
            return View();
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
            try
            {
                eSkoolDBContext dbcontext = new eSkoolDBContext();
                
            }
            catch(Exception ex)
            {

            }
            return View();
        }




        [HttpGet]
        public IActionResult addStudent()
        {
            return View();
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
            return View();
        }



        [HttpGet]
        public IActionResult addQuestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addQuestion(string Syllabus,string Class,string Questiontype,string Subject,string Chapter,
            string Exercise,string Statement,string Option1=null, string Option2=null, string Option3=null, string Option4=null, string CorrectOption=null)
        {
            return View();
        }
        public IActionResult questionNotification()
        {
            return View();
        }

        [HttpGet]
        public IActionResult addClass()
        {

            List<UserInfo> Teachers=null;
            try
            {
                using (eSkoolDBContext eskoolDb=new eSkoolDBContext())
                {
                   Teachers= eskoolDb.UserInfos.ToList();

                }
            }
            catch(Exception e)
            {

            }

            return View(Teachers);
        }

        [HttpPost]
        public IActionResult addClass(string className,string grade,string teacherName,int strength)
        {
            return View();
        }
        public IActionResult showClasses()
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

    }
}
