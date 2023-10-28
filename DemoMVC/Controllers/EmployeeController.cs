using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
//Nghiem Thi Van Anh -2021050078
    public class EmployeeController : Controller
    {
         public IActionResult Index()
            {
                return View();
//Nghiem Thi Van Anh -2021050078
            }
            [HttpPost]
         public IActionResult Index(Employee emp)
            {
//Nghiem Thi Van Anh -2021050078
                string str = emp.FullName + "_" + emp.EmployeeID + "_" + emp.SoDienThoai +"_"+ emp.Address; 
                ViewBag.KetQua = str;
                return View();
//Nghiem Thi Van Anh -2021050078
            }
    }
}