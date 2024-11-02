using FitnessTracker.Models.Person;

namespace FitnessTracker.Sevices.Interfaces
{
    public interface IPersonService
    {

        void Add(CreatePersonViewModel Person);

        IEnumerable<PersonViewModel> GetAll();

        void Delete(int id);

        PersonViewModel Get(int id);


    }
}
