using crud.Services.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult getUsers()
        {
           
            return Ok(_repository.GetUsers());
        }

        [HttpGet("{id}")]
        public IActionResult getUser(int id) {
            var user = _repository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
