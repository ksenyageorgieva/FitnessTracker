using FitnessTracker.Data;
using FitnessTracker.Models;
using FitnessTracker.Models.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace FitnessTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
       

        public IActionResult Person ()
        {
            return View();  
        }
       
        public IActionResult AddEditPerson()
        {
            return View();
        }
        [HttpPost]

        //public IActionResult AddEditPersonForm(Person entity)
        //{
        //    _context.Persons.Add();
        //    _context.SaveChanges();
        //    return RedirectToAction("Person");
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
