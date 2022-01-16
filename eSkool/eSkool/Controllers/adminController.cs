using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using eSkool.Models;
using System.Collections.Generic;
using System.Linq;
using eSkool.Logistics;

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
                            List<ClassSubjectTeacher> teachers = null;
                            try
                            {
                                using (eSkoolDBContext eskoolDb = new eSkoolDBContext())
                                {
                                    teachers = eskoolDb.ClassSubjectTeachers.ToList();

                                }
                            }
                            catch (Exception e)
                            {

                            }

                            return View(teachers);
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
        public IActionResult addTeacher(Teacher TeacherInfoObj,string TeacherEmail)
        {
            if(HttpContext.Session.GetString("username") != null)
            {
                
                try
                {
                    using (eSkoolDBContext dBContext = new eSkoolDBContext())
                    {
                        //TeacherId==UserName
                        TeacherInfoObj.TeacherId = Algorithms.generateTeacherUsername(TeacherEmail);

                        //Add Teacher Credential In UserInfo Table
                        UserInfo user = new UserInfo(TeacherInfoObj.TeacherId, "T");
                        dBContext.UserInfos.Add(user);

                        //Add Teacher Complete Info Teacher Table
                        dBContext.Teachers.Add(TeacherInfoObj);

                        //Update DB
                        dBContext.SaveChanges();                        
                    
                    }
                }
                catch (Exception ex)
                {
                    
                }
                return RedirectToAction("showTeachers", "admin");
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
                            try
                            {
                                using(eSkoolDBContext dBContext=new eSkoolDBContext())
                                {
                                    List<Teacher> TeacherList = dBContext.Teachers.ToList();
                                   return View(TeacherList);
                                }
                            }
                            catch(Exception ex)
                            {
                                return View();
                            }

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
        public IActionResult addStudent(Student studentinfoObj ,string StudentAge)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                
                try
                {
                    using (eSkoolDBContext dBContext = new eSkoolDBContext())
                    {
                        //admisionDate
                        studentinfoObj.AdmissionDate = DateTime.Today;

                        //Age
                        string[] temp  = StudentAge.Split(" ");
                        studentinfoObj.StudentAge = Convert.ToInt32(temp[0]);

                        //rollNumber
                        int roll=dBContext.Students.Where(x => x.ClassGrade == studentinfoObj.ClassGrade).ToList().Count;
                        studentinfoObj.RollNumber = (roll+1).ToString();
                        
                        //stundetId= WHICH IS HIS USER NAME
                        studentinfoObj.StudentId = Algorithms.generateStudentUsername(studentinfoObj.StudentName, studentinfoObj.FatherName, studentinfoObj.RollNumber,Convert.ToInt32(studentinfoObj.ClassGrade));

                        //student Class set
                        if (dBContext.SchoolClasses.Find(studentinfoObj.ClassGrade, studentinfoObj.ClassName) == null)
                        {
                            studentinfoObj.ClassName = null;
                            studentinfoObj.ClassGrade = null;
                        }

                        //add student Credential  in USERINFO
                        UserInfo user = new UserInfo(studentinfoObj.StudentId,"S");
                        dBContext.Add(user);                        
                        
                        //Add student Complete Info in Student Table
                        dBContext.Students.Add(studentinfoObj);
                       
                        //Update DB
                        dBContext.SaveChanges();
                                               
                    }
                }
                catch (Exception ex)
                {
                    
                }
                return RedirectToAction("showStudents", "admin");
             }
           return RedirectToAction("login", "login");
        }






        [HttpGet]
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
                            ViewBag.classGrade = "All";
                            ViewBag.className = "All";
                            try
                            {
                                using(eSkoolDBContext dBContext=new eSkoolDBContext())
                                {
                                    List<Student> studentList= dBContext.Students.ToList();
                                    return View(studentList);
                                }
                            }
                            catch(Exception ex)
                            {
                                return RedirectToAction("showStudents", "admin");
                            }
                           

                            
                        }
                        //Coding Block---------------------------------------------------------
                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
         
        }






        [HttpPost]
        public IActionResult showStudents(int ClassGrade ,string className)
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
                            ViewBag.classGrade = ClassGrade;
                            ViewBag.className = className;
                            try
                            {
                                using (eSkoolDBContext dBContext = new eSkoolDBContext())
                                {
                                   List<Student> StudentList= dBContext.Students.Where(x => x.ClassGrade == ClassGrade && x.ClassName == className).ToList();
                                    return View(StudentList);
                                }
                            }
                            catch
                            {
                                return RedirectToAction("showStudents", "admin");
                            }                            
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
