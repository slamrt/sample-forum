using Microsoft.EntityFrameworkCore;
using SampleForum.Entities;
using Microsoft.Extensions.Configuration;



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
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SampleForumDb"));
           
        }
    }
}
