using FitnessTracker.Models.Person;

namespace FitnessTracker.Sevices.Interfaces
{
    public interface IPersonService
    {

        void Add(CreatePersonViewModel person);

        IEnumerable<PersonViewModel> GetAll();

        void Delete(int id);

        PersonViewModel Get(int id);


    }
}
