﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using eSkool.Models;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eSkool.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
                    {
                        ViewBag.username = username;

                        {

                          
                            return View();                         
                        }

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }

            return RedirectToAction("login", "login");

        }  





        public ActionResult download_books()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
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






        public ActionResult subjects()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
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






        public ActionResult helping_material()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
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






        public ActionResult class_announcement()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
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






        public ActionResult challan()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {

                            ViewBag.uname = HttpContext.Session.GetString("username");
                            return View();                            
                        }
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }

            return RedirectToAction("login", "login");            
        }








        public ActionResult attendance()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
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





        public ActionResult gradebook()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
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





        public ActionResult practice()
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
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





        public ActionResult download(string filePath)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
                    {
                        ViewBag.username = username;

                        //Coding Block---------------------------------------------------------
                        {

                            string fullName = "wwwroot" + filePath;
                            //string fullName = Server.MapPath("~" + filePath);
                            byte[] fileBytes = GetFile(fullName);
                            return File(
                                fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filePath);
                        }
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }

            return RedirectToAction("login", "login");            
        }       
        byte[] GetFile(string s)
        {
            System.IO.FileStream fs = System.IO.File.OpenRead(s);
            byte[] data = new byte[fs.Length];
            int br = fs.Read(data, 0, data.Length);
            if (br != fs.Length)
                throw new System.IO.IOException(s);
            return data;
        }




    }//End Controller
}