using FitnessTracker.Models.Person;
using FitnessTracker.Sevices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Controllers
{
    public class PersonController : Controller

    {

        private readonly IPersonService personService;


        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        public IActionResult Index()
        {
            var persons = personService.GetAll();

            return View(persons); //Display all entries (persons) from the getall
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(CreatePersonViewModel Person)
        {
            personService.Add(Person);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            personService.Delete(id);

            return RedirectToAction(nameof(Index));

        }
    }

}
