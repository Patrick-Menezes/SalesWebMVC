using Microsoft.AspNetCore.Mvc;

namespace Saleswebmvc.Controllers
{
    public class SallesRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSearch()
        {
            return View();
        }

        public IActionResult GroupingSearch()
        {
            return View();
        }

    }
}
