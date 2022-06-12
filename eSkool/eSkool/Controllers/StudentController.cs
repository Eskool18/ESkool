using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using eSkool.Models;
using Grpc.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eSkool.Logistics;
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
                        ActiveUser.recordActive(username);

                        try
                            {
                                using (eSkoolDBContext dBContext = new eSkoolDBContext())
                                {
                                    List<Notice> NoticeList = dBContext.Notices.ToList();
                                    return View(NoticeList);
                                }
                            }
                            catch (Exception ex)
                            {
                                return View();
                            }

                                             
                       
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }

            return RedirectToAction("login", "login");

        }  


        //[HttpPost]
        //public IActionResult Dashboard( string uname, string complaint)
        //{
        //    if (HttpContext.Session.GetString("username") != null)
        //    {
        //        string username = HttpContext.Session.GetString("username");
        //        using (eSkoolDBContext db = new eSkoolDBContext())
        //        {
        //            string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
        //            if (role == "S")
        //            {
                        
        //                try
        //                {
        //                    using (eSkoolDBContext dBContext = new eSkoolDBContext())
        //                    {
        //                        Complaint newComplaint = new Complaint();
        //                        newComplaint.ComplaintStatement = complaint;
        //                        newComplaint.UserName = username;
                            
        //                        newComplaint.ComplaintDate = DateTime.Now;
                                      
        //                        dBContext.Complaints.Add(newComplaint);

        //                        //Update DB
        //                        dBContext.SaveChanges();

        //                       RedirectToAction("Dashboard");
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    return View();
        //                }



        //            }
        //            else return RedirectToAction("AccessWarning403", "login", new { role = role });
        //        }

        //    }

        //    return RedirectToAction("login", "login");

        //}

        [HttpPost]
        public IActionResult Dashboard( string reason, DateTime from, DateTime to, string txt, int total)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
                    {
                        ActiveUser.recordActive(username);

                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                Application newApp= new Application();
                                string id = db.Students.Where(x => x.StudentName == username).SingleOrDefault().StudentId;
                                newApp.StudentId = id ;
                                newApp.SubmissionDate = DateTime.Now;
                                newApp.ApplicationToDate = to;
                                newApp.ApplicationFromDate = from;
                                newApp.ApplicationBody = txt;
                                newApp.AppicationTitle = reason;
                                newApp.TotalDays = total;
                                

                                dBContext.Applications.Add(newApp);

                                //Update DB
                                dBContext.SaveChanges();

                                RedirectToAction("Dashboard");
                            }
                        }
                        catch (Exception ex)
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
                        ActiveUser.recordActive(username);
                        //Coding Block---------------------------------------------------------
                        {
                            try
                            {
                                using (eSkoolDBContext dBContext = new eSkoolDBContext())
                                {
                                    List<HelpingMeterial> AppList = dBContext.HelpingMeterials.ToList();
                                    return View(AppList);
                                }

                            }
                            catch (Exception ex)
                            {

                            }


                        }
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
                        ActiveUser.recordActive(username);

                        //int? grade = db.Students.Where(x => x.StudentName == username).SingleOrDefault().ClassGrade;
                        //Coding Block---------------------------------------------------------
                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                Student studentobj = db.Students.Where(x => x.StudentName == username).SingleOrDefault();
                               
                                List<ClassSubjectTeacher> subList = db.ClassSubjectTeachers.Where(x => x.ClassName == studentobj.ClassName
                                  && x.ClassGrade == studentobj.ClassGrade).ToList();
                                return View(subList);
                            }

                        }
                        catch (Exception ex)
                        //Coding Block---------------------------------------------------------
                        {

                            return View();
                        }
                        //Coding
                        //Coding Block---------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }

            return RedirectToAction("login", "login");            
        }

        public ActionResult helping_material(string sName)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    int? cName = db.Students.Where(x => x.StudentName == username).SingleOrDefault().ClassGrade;
                    if (role == "S")
                    {
                        ViewBag.username = username;
                        ActiveUser.recordActive(username);
                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                List<HelpingMeterial> AppList = dBContext.HelpingMeterials.Where(x => x.MaterialSubject == sName && x.MaterialClass == cName ).ToList();
                                return View(AppList);
                            }

                        }
                        catch(Exception ex)
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


        public ActionResult class_announcement(string sName)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    string cName = db.Students.Where(x => x.StudentName == username).SingleOrDefault().ClassName;
                    if (role == "S")
                    {
                        ViewBag.username = username;
                        ActiveUser.recordActive(username);
                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                List<ClassAnnouncement> AppList = dBContext.ClassAnnouncements.Where(x => x.Subject == sName && x.ClassName == cName).ToList();
                                return View(AppList);
                            }

                        }
                        catch (Exception ex)
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
                        ActiveUser.recordActive(username);
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

            return RedirectToAction("login", "login");
        }

        public ActionResult gradebook(string sName)
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
                        ActiveUser.recordActive(username);
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
