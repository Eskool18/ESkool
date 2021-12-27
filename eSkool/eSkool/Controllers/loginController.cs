using eSkool.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace eSkool.Controllers
{
    public class loginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String user,String password)
        {
            try
            {
                using (eSkoolDBContext dBContext = new eSkoolDBContext())
                {

                    UserInfo temp;
                    //int id = 1004;
                    //temp = dBContext.UserInfos.Find(userName);
                    temp = dBContext.UserInfos.Where(x => x.UserName == user).SingleOrDefault();
                    if (temp != null && temp.UserName == user && temp.Password == password)
                    {
                        HttpContext.Session.SetString("username", user);
                        HttpContext.Session.SetString("password", password);
                        if(temp.Role=="A")
                            return RedirectToAction("adminDashboard","admin");
                        if (temp.Role == "T")
                            return RedirectToAction("Dashboard", "Teacher");
                        if (temp.Role == "S")
                            return RedirectToAction("Dashboard", "Student");
                    }
                    return View();
                }
            }catch(Exception ex)
            {
                return View();
            }
            
            
        }
    }
}
