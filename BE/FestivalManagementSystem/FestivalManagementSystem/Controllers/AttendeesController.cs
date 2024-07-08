using Microsoft.AspNetCore.Mvc;

namespace FestivalManagementSystem.Controllers
{
    public class AttendeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
