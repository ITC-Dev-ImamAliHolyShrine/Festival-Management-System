using Microsoft.AspNetCore.Mvc;

namespace FestivalManagementSystem.Controllers
{
    public class ActivitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
