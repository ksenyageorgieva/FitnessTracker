using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }

}
