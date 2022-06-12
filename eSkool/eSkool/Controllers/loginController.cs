using eSkool.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using eSkool.Logistics;

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
                        ActiveUser.recordActive(user);
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
        public IActionResult Logout()
        {
            ActiveUser.recordInActive(HttpContext.Session.GetString("username"));
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("passwrod");
            return RedirectToAction("login");
        }

        public IActionResult AccessWarning403(string role)
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("passwrod");
            ViewBag.AccessWarningRole = getCompleteRole(role);
            return View();
        }

        string getCompleteRole(string role)
        {
            if (role == "A")
                return "Admin";
            else if (role == "S")
                return "Student";
            else if(role=="T") 
                return "Teacher";

            return "Anonymous User";
        }
   
    
        public IActionResult temp()
        {
            return View();
        }
    }//End Controller
}
