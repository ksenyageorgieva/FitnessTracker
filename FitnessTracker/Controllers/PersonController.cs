using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
