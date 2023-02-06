using Microsoft.AspNetCore.Mvc;

namespace SampleForum.Controllers
{
    public class UsersController : Controller
    {
        [Route("/api[controller]")]
        private IUsersRepository usersRepository;
        public IActionResult Index()
        {
            return View();
        }
    }
}
