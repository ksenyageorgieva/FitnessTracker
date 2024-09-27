using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models
{
    public class Person
    {
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Age { get; set; }
        [Required]
        public decimal Weight { get; set; }

    }
}
