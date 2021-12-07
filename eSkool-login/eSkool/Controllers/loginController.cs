using eSkool.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Login(String userName,String password)
        {
            try
            {
                using (eSkoolDBContext dBContext = new eSkoolDBContext())
                {
                    int key = 1004;
                    UserInfo temp = new UserInfo();
                    temp = dBContext.UserInfos.FirstOrDefault(f => f.UserName==userName);
                    if (temp != null && temp.UserName == userName && temp.Password == password)
                    {
                        HttpContext.Session.SetString("user", "5");
                        return RedirectToAction("signUp","signup");
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
