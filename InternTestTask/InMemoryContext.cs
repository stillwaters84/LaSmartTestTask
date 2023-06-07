using InternTestTask.Models;
using Microsoft.EntityFrameworkCore;
namespace InternTestTask
{
    public class InMemoryContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "LaSmartDb");
        }
        public DbSet<Point> Points { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
