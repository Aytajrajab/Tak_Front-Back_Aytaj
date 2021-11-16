using Microsoft.AspNetCore.Mvc;

namespace ArtBaking.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
