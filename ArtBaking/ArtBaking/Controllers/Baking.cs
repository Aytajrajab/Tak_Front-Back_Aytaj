using Microsoft.AspNetCore.Mvc;

namespace ArtBaking.Controllers
{
    public class Baking : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
