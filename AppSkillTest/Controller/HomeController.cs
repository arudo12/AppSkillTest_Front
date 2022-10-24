using Microsoft.AspNetCore.Mvc;

namespace AppSkillTest.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
