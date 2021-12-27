using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;

namespace eSkool.Controllers
{
    public class Student : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public ActionResult download_books()
        {
            return View();
        }
        public ActionResult subjects()
        {
            return View();
        }
        public ActionResult helping_material()
        {
            return View();
        }
        public ActionResult class_announcement()
        {
            return View();
        }
        public ActionResult challan()
        {
            return View();
        }
        public ActionResult attendance()
        {
            return View();
        }
        public ActionResult download(string filePath)
        {
            string fullName = "wwwroot" + filePath;
            //string fullName = Server.MapPath("~" + filePath);
            byte[] fileBytes = GetFile(fullName);
            return File(
                fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, filePath);
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
