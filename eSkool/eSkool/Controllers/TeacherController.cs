using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using eSkool.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using eSkool.Logistics;

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

                        //Coding Block------------------------------------------------------------

                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                List<Application> AppList = dBContext.Applications.ToList();
                                return View(AppList);
                            }
                        }
                        catch (Exception ex)
                        {
                            return View();
                        }


                        //Coding Block--------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
        }
        public IActionResult setPaper()
        {
            return View();
        }
        public IActionResult upload_gradebook(string sname, string cname)
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

                        //Coding Block------------------------------------------------------------

                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                List<Application> AppList = dBContext.Applications.ToList();
                                return View(AppList);
                            }
                        }
                        catch (Exception ex)
                        {
                            return View();
                        }


                        //Coding Block--------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
        }
        public IActionResult post_class_announcement(string sname, string cname)
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
                        ViewBag.sname = sname;
                        ViewBag.cname = cname;
                        //Coding Block------------------------------------------------------------

                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                List<ClassAnnouncement> announcement = dBContext.ClassAnnouncements.Where(x => x.Subject == sname && x.ClassName == cname).ToList();
                                return View(announcement);
                                //return View();
                            }
                        }
                        catch (Exception ex)
                        {
                            return View();
                        }


                        //Coding Block--------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
        }
        [HttpPost]
        public IActionResult post_class_announcement(string title,string txt, string cls, string sub)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                string username = HttpContext.Session.GetString("username");
                using (eSkoolDBContext db = new eSkoolDBContext())
                {
                    string role = db.UserInfos.Where(x => x.UserName == username).SingleOrDefault().Role;
                    if (role == "T")
                    {
                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {

                                ClassAnnouncement newAnnouncement = new ClassAnnouncement();
                                newAnnouncement.ClassName = cls;
                                newAnnouncement.Content = txt;
                                newAnnouncement.Header = title;
                                newAnnouncement.PostDate = DateTime.Now;
                                newAnnouncement.Subject = sub;
                                newAnnouncement.Username = username;
                                dBContext.ClassAnnouncements.Add(newAnnouncement);

                                //Update DB
                                dBContext.SaveChanges();
                                
                                return RedirectToAction("post_class_announcement", "Teacher", new { sname = sub, cname = cls });



                            }
                        }
                        catch (Exception ex)
                        {
                           
                        }
                       
                    }
                    return RedirectToAction("post_class_announcement", "Teacher");
                   
                }
            }
            return RedirectToAction("login", "login");
        }

        public IActionResult upload_helping_material(string sname, int? cname)
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
                        ViewBag.sname = sname;
                        ViewBag.cname = cname;
                        //Coding Block------------------------------------------------------------

                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                List<HelpingMeterial> AppList = dBContext.HelpingMeterials.Where(x => x.MaterialSubject == sname && x.MaterialClass == cname).ToList();
                                return View(AppList);
                            }
                        }
                        catch (Exception ex)
                        {
                            return View();
                        }


                        //Coding Block--------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> upload_helping_material(List<IFormFile> files, string sName, int cName, string mType)
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

                        //Coding Block------------------------------------------------------------

               
                        long size = files.Sum(f => f.Length);

                        var filePaths = new List<string>();
                        foreach (var formFile in files)
                        {
                            if (formFile.Length > 0)
                            {
                                // full path to file in temp location
                                string filePath = Path.Combine("wwwroot/lib/", formFile.FileName);//we are using Temp file name just for the example. Add your own file path.
                                filePaths.Add(filePath);

                                using (var stream = new FileStream(filePath, FileMode.Create))
                                {


                                    await formFile.CopyToAsync(stream);
                                }
                                //your logic to save filePath to database, for example
                                try
                                {
                                    using (eSkoolDBContext dBContext = new eSkoolDBContext())
                                    {

                                        HelpingMeterial newMaterial = new HelpingMeterial();
                                        newMaterial.MaterialClass = cName;
                                        newMaterial.MaterialName = formFile.FileName;
                                        newMaterial.MaterialSubject = sName;
                                        newMaterial.MaterialType = mType;
                                        newMaterial.UserName = username;
                                        dBContext.HelpingMeterials.Add(newMaterial);

                                        //Update DB
                                        await dBContext.SaveChangesAsync();

                                        return RedirectToAction("upload_helping_material", "Teacher", new { sname = sName, cname = cName  });
                                    


                                }
                                }
                                catch (Exception ex)
                                {

                                }
                    
                            }
                        }

                        return Ok(new { count = files.Count, size, filePaths });
                    }
                
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
        }
        public IActionResult teach_subject()
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

                        //Coding Block------------------------------------------------------------

                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                Teacher teacherobj = db.Teachers.Where(x => x.TeacherName == username).SingleOrDefault();

                                List<ClassSubjectTeacher> subList = db.ClassSubjectTeachers.Where(x => x.TeacherId == teacherobj.TeacherId
                                 ).ToList();
                                return View(subList);
                            }
                        }
                        catch (Exception ex)
                        {
                            return View();
                        }


                        //Coding Block--------------------------------------------------------

                    }
                    else return RedirectToAction("AccessWarning403", "login", new { role = role });
                }

            }
            return RedirectToAction("login", "login");
        }
        public IActionResult leaveBox()
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

                        //Coding Block------------------------------------------------------------

                        try
                        {
                            using (eSkoolDBContext dBContext = new eSkoolDBContext())
                            {
                                List<Application> AppList = dBContext.Applications.ToList();
                                return View(AppList);
                            }
                        }
                        catch (Exception ex)
                        {
                            return View();
                        }


                        //Coding Block--------------------------------------------------------

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
                    if (role == "T")
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

    }
}
