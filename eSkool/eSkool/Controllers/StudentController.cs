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
        public IActionResult Dashboard(string check, string uname, string complaint, string reason, DateTime from, DateTime to, string txt, int total)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
                    {

                        
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                            try
                            {
                                if (check == "leave")
                                {
                                    Application newApp = new Application();
                                    string id = username;
                                    newApp.StudentId = id;
                                    newApp.SubmissionDate = DateTime.Now;
                                    newApp.ApplicationToDate = to;
                                    newApp.ApplicationFromDate = from;
                                    newApp.ApplicationBody = txt;
                                    newApp.AppicationTitle = reason;
                                    newApp.TotalDays = total;


                                    dBContext.Applications.Add(newApp);

                                    //Update DB
                                    dBContext.SaveChanges();
                                }
                                else if (check == "complaint")
                                {
                                    Complaint newComplaint = new Complaint();
                                    newComplaint.ComplaintStatement = complaint;
                                    newComplaint.UserName = username;

                                    newComplaint.ComplaintDate = DateTime.Today;

                                    dBContext.Complaints.Add(newComplaint);
                                  
                                }
                                //Update DB
                                dBContext.SaveChanges();
                                
                                    ViewBag.username = username;
                                    ActiveUser.recordActive(username);
                                    List<Notice> NoticeList = dBContext.Notices.ToList();
                                return View(NoticeList);
                             
                            }
                            catch (Exception ex)
                            {
                                List<Notice> NoticeList = dBContext.Notices.ToList();
                                return View(NoticeList);

                            }
                        }
                       



                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }

            return RedirectToAction("login", "login");

        }
        //public IActionResult Dashboard( string reason, DateTime from, DateTime to, string txt, int total)
        //{
        //    if (HttpContext.Session.GetString("username") != null)
        //    {
        //        string username = HttpContext.Session.GetString("username");
        //        using (eSkoolDBContext db = new eSkoolDBContext())
        //        {
        //            string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
        //            if (role == "S")
        //            {
        //                ActiveUser.recordActive(username);

        //                try
        //                {
        //                    using (eSkoolDBContext dBContext = new eSkoolDBContext())
        //                    {
        //                        Application newApp= new Application();
        //                        string id = db.Students.Where(x => x.StudentName == username).SingleOrDefault().StudentId;
        //                        newApp.StudentId = id ;
        //                        newApp.SubmissionDate = DateTime.Now;
        //                        newApp.ApplicationToDate = to;
        //                        newApp.ApplicationFromDate = from;
        //                        newApp.ApplicationBody = txt;
        //                        newApp.AppicationTitle = reason;
        //                        newApp.TotalDays = total;


        //                        dBContext.Applications.Add(newApp);

        //                        //Update DB
        //                        dBContext.SaveChanges();

        //                        RedirectToAction("Dashboard");
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
                                //List<ClassAnnouncement> AppList = dBContext.ClassAnnouncements.Where(x => x.Subject == sName && x.ClassName == cName).ToList();
                               // return View(AppList);
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

        public ActionResult attendance(string attendenceMonth)
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
                            string[] months = { "January", "February", "March", "April", "May", "June", "July", "Auguest", "Septemer", "October", "Novmber", "December" };
                            ViewBag.months = months;
                            if (attendenceMonth == null)
                                attendenceMonth = months[DateTime.Today.Month - 1];
                            ViewBag.attendenceMonth = attendenceMonth;
                            int daysInmonth = DateTime.DaysInMonth(DateTime.Now.Year, getIndexMonth(attendenceMonth, months));
                            ViewBag.DaysInMonth = daysInmonth;
                            ViewBag.monthNum = getIndexMonth(attendenceMonth, months);
                            //object of attendence stuff
                             studentMonthlyAttendence student = new studentMonthlyAttendence();

                           //get student all attendence
                               
                                List<Attendence> studentAttendence = db.Attendences.Where(x => x.StudentId == username).ToList();
                                List<Attendence> temp = new List<Attendence>();
                                foreach (var selectedStudent in studentAttendence)
                                {
                                    if (Convert.ToInt32(selectedStudent.AttendenceDate.ToString().Split("/")[1]) == getIndexMonth(attendenceMonth, months))
                                        temp.Add(selectedStudent);
                                }

                                studentAttendence.Clear();
                                studentAttendence = temp;

                                foreach (var attendence in studentAttendence)
                                {
                                    int index = Convert.ToInt32(attendence.AttendenceDate.ToString().Split("/")[0]);
                                    if (attendence.AttendenceStatus != null)
                                        student.days[index - 1] = Convert.ToInt32(attendence.AttendenceStatus.ToString());
                                }   


                            return View(student);
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


        int getIndexMonth(string month, string[] months)
        {
            int i = 1;
            foreach (var m in months)
            {
                if (m == month)
                    return i;
                i++;
            }
            return i - 1;
        }

        [HttpGet]
        public IActionResult manageProfile(string id)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                UserInfo temp = new UserInfo();
                using (eSkoolDBContext eskoolDb = new eSkoolDBContext())
                {
                    string role = eskoolDb.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "S")
                    {
                        try
                        {
                            using (eSkoolDBContext eskoolDB = new eSkoolDBContext())
                            {
                                temp = (UserInfo)eskoolDB.UserInfos.Where(user => user.UserName == id).SingleOrDefault();
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                        return View(temp);
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }
            }
            return RedirectToAction("login", "login");
        }

        [HttpPost]
        public IActionResult manageProfile(string id, string newPassword)
        {
            if (HttpContext.Session.GetString("username") != null && newPassword != null)
            {
                string username = HttpContext.Session.GetString("username");
                UserInfo temp = new UserInfo();
                using (eSkoolDBContext eskoolDB = new eSkoolDBContext())
                {

                    temp = eskoolDB.UserInfos.Where(user => user.UserName == username).SingleOrDefault();
                    temp.Password = newPassword;
                    eskoolDB.UserInfos.Update(temp);
                    eskoolDB.SaveChanges();
                    return RedirectToAction("Dashboard", "Student");
                }
            }
            else { return RedirectToAction("manageProfile", "Student"); }
            return RedirectToAction("login", "login");
        }
    }

}//End Controller

