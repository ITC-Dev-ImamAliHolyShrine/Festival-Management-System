using Microsoft.AspNetCore.Mvc;

namespace FestivalManagementSystem.Controllers
{
    public class GuestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
