using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace eSkool.Controllers
{
    public class signupController : Controller
    {
        public IActionResult signUp()
        {

            if (HttpContext.Session.GetString("username") != null)
            {
                return View();
            }
            return RedirectToAction("login", "login");
        }

        

        
    }
}
