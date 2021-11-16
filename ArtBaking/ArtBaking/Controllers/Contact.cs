using Microsoft.AspNetCore.Mvc;

namespace ArtBaking.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
