using SampleForum.Entities;
using SampleForum.Models;

namespace SampleForum.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public List<User> GetUsers()
        {
            using(var dbContext = new DAL())
            {
                return dbContext.Users.ToList();
            }
        }

        public void UpdateUser(User user)
        {
            using(var dbContext = new DAL())
            {
                dbContext.Users.Update(user);
                dbContext.SaveChanges();
            }
        }
    }
}
