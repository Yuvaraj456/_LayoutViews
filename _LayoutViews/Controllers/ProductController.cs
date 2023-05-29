using Microsoft.AspNetCore.Mvc;

namespace _LayoutViews.Controllers
{
    public class ProductController : Controller
    {
        [Route("/Products")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Search")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("/Order")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
