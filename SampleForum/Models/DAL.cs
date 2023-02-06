using Microsoft.EntityFrameworkCore;
using SampleForum.Entities;

namespace SampleForum.Models
{
    public class DAL : DbContext
    {
        public DAL()
        {
            Database.EnsureCreated();
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SampleForum;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;");
        }
    }
}
