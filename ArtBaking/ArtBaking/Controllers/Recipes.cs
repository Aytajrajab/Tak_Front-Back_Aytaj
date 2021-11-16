using Microsoft.AspNetCore.Mvc;

namespace ArtBaking.Controllers
{
    public class Recipes : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
