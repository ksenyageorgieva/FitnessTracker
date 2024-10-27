using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FitnessTracker.Models.Data.Entity
{
    

    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; } //beshe decimal
         
        public Person() { 
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }

}
