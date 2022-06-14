using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HomeController1 : Controller
    {
        public ViewResult login()
        {
            int[] a = { 1, 2, 3, 4 };
            ViewData["data"] = a;
            return View();  
        }

    }
}
