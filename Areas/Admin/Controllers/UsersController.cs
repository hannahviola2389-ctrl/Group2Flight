using Microsoft.AspNetCore.Mvc;

namespace Group1Flight.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Manage()
        {
            return Content("Admin Manage Users Page");
        }
    }
}
