using _LayoutViews.Model;
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
        [Route("/ParcialResult")]
        public IActionResult ParcialResult()
        {
            ListModel listModel = new ListModel()
            {
                 ListName = "Programming Languages",
                ListItems = new List<string>(){ "Java", "C#", "Python", "Ruby" }
            };

            return  PartialView("_ListParcialView",listModel);
        }
    }
}
