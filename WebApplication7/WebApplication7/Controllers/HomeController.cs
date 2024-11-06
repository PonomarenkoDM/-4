using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index(string name="Oleg", string color = "Black")
        {
            ViewBag.Name = name;
            ViewBag.Color = color;

            return View();
        }
    }
}
