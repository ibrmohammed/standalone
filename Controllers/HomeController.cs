using Microsoft.AspNetCore.Mvc;

namespace standalone
{
    public class HomeController : Controller 
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }   
}