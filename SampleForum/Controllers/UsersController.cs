using Microsoft.AspNetCore.Mvc;
using SampleForum.Entities;
using SampleForum.Repositories;

namespace SampleForum.Controllers
{
    [Route("/api[controller]")]
    public class UsersController : Controller
    {
        private IUsersRepository usersRepository;
        public UsersController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        [HttpGet]
        public List<User> GetUsers() 
        
        {
            List<User>? users = usersRepository.GetUsers();
            List<User> result = users.Select(u =>new User { 
                Id = u.Id,
                FirstName= u.FirstName,
                LastName= u.LastName,
                Email = u.Email,
                Username= u.Username,
                Password=u.Password,
                })
                .ToList();
            return result;
        }

        [HttpPut]
        public IActionResult UpdateUser(User user) 
        {
            if (user == null) { return BadRequest(ModelState); }
            usersRepository.UpdateUser(user);
            return Ok();
        }

        
    }
}
