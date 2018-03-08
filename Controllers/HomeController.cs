using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace timeDisplay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")] 
        public IActionResult index()
        {
            return View();
        }
    }
}