using System.Reflection.Metadata.Ecma335;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{ //Nghiem Thi Van Anh - MSV : 2021050078
     public class PersonController : Controller
    {
         public IActionResult Index()
            {
                return View();
 //Nghiem Thi Van Anh - MSV : 2021050078
            }
        [HttpPost]
        public IActionResult Index(Person prs)
        {
            string str = prs.PersonID +"_" + prs.FullName;
            ViewBag.thongBao = str;
            return View();
        }
 //Nghiem Thi Van Anh - MSV : 2021050078        
    }
}