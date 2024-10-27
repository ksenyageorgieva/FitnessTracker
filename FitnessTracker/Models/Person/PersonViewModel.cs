namespace FitnessTracker.Models.Person
{
    public class PersonViewModel
    {
        private object personid;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public PersonViewModel(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public PersonViewModel(object personid)
        {
            this.personid = personid;
        }
    }
}
