using Microsoft.AspNetCore.Mvc;

namespace Saleswebmvc.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
