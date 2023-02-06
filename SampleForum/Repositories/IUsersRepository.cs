using SampleForum.Entities;

namespace SampleForum.Repositories
{
    public interface IUsersRepository
    {
        List<User> GetUsers();
        public void UpdateUser(User user);

    }
}
