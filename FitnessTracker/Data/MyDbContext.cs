using FitnessTracker.Models.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Data
{

    public class MyDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {

        }

    }
}
