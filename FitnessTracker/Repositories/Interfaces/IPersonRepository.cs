using FitnessTracker.Models.Data.Entity;
using FitnessTracker.Models.Person;

namespace FitnessTracker.Repositories.Interfaces
{
    public interface IPersonRepository
    {

            void Add(Person person);

            IEnumerable<Person> GetAll(); 

          
            void Delete(int id);

            PersonViewModel Get(int id);
        


    }
}
