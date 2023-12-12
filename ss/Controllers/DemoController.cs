using Microsoft.AspNetCore.Mvc;
//2021050078-Nghiêm Thị Vân Anh
namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        // khai báo các phương thức
            public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

           public IActionResult Index(string fName, string email)
        {
            string strResult = "Hello" + fName + "-" + email;
            ViewBag.ThongBao = strResult;
            return View();
        }

    }
}