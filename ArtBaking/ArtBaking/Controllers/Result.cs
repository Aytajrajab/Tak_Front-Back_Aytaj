using Microsoft.AspNetCore.Mvc;

namespace ArtBaking.Controllers
{
    public class Result : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
