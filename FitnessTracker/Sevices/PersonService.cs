using FitnessTracker.Models.Data.Entity;
using FitnessTracker.Models.Person;
using FitnessTracker.Repositories.Interfaces;
using FitnessTracker.Sevices.Interfaces;

namespace FitnessTracker.Sevices
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository personRepository;


        public PersonService(IPersonRepository personRepository)
        {

            this.personRepository = personRepository;


        }
        public void Add(CreatePersonViewModel Person) //person is object
        {
            var PersonEntity = new Person(Person.FirstName, Person.LastName, Person.Age);

            personRepository.Add(PersonEntity); //ako e cherveno ne e implemetinrano?
        }
        public IEnumerable<PersonViewModel> GetAll()
        {
            var PersonEntities = personRepository.GetAll();

            var persons = PersonEntities.Select(Person => new PersonViewModel(Person.Id, Person.FirstName, Person.LastName, Person.Age));

            return persons;
        }

        public void Delete(int id)
            => personRepository.Delete(id); 

        public PersonViewModel Get(int id)
        {
            var personid = personRepository.Get(id);

            return new PersonViewModel(personid); 
        }



    }
}
