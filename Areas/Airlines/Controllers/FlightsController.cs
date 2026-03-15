using Microsoft.AspNetCore.Mvc;

namespace Group1Flight.Areas.Airlines.Controllers
{
    [Area("Airlines")]
    public class FlightsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return Content("Manage Flights Page");
        }
    }
}
