using FitnessTracker.Models.Data.Entity;
using FitnessTracker.Repositories.Interfaces;
using FitnessTracker.Data;
using FitnessTracker.Models.Person;


namespace FitnessTracker.Repositories
{
    public class PersonRepository : IPersonRepository
    {


        private readonly MyDbContext context; 

        public PersonRepository(MyDbContext context)
        {
            this.context = context;
        }
        public void Add(Person person)
        {
            context.Persons.Add(person);
            context.SaveChanges();  
        }

        public IEnumerable<Person> GetAll() 
        => context.Persons.ToList();    

        public void Delete(int id)
        {
            var Personid = Get(id);       
            context.Persons.Remove(Personid);
            context.SaveChanges();

        }

        public Person Get(int id) 
           => context.Persons.FirstOrDefault(PersonsID => PersonsID.Id == id);

        PersonViewModel IPersonRepository.Get(int id) 
        {
            throw new NotImplementedException();
        }
    }


}

