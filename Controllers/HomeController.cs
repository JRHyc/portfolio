using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace timeDisplay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("home")] 
        public IActionResult home()
        {
            return View();
        }
        
        [HttpGet]
        [Route("project")] 
        public IActionResult project()
        {
            return View();
        }

        [HttpGet]
        [Route("contact")] 
        public IActionResult contact()
        {
            return View();
        }
    }
}