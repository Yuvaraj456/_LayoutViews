using Microsoft.AspNetCore.Mvc;

namespace _LayoutViews.Controllers
{
    public class ParcialController : Controller
    {
        [Route("/ParcialHome")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/ParcialAbout")]
        public IActionResult About()
        {
            return View();
        }
    }
}
