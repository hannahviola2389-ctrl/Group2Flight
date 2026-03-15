using Microsoft.AspNetCore.Mvc;

namespace Group1Flight.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return Content("Search Flights Page");
        }
    }
}
