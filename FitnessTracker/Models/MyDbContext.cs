using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Models
{
    public class MyDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {

        }

        protected MyDbContext()
        {
        }
    }



}
