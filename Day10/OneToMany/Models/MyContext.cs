using Microsoft.EntityFrameworkCore;
namespace OneToMany.Models
{ 
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Creature> Creatures { get; set; }
    }
}