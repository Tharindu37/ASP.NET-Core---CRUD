using AutoMapper;
using crud.Services.Models;
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
        private readonly IMapper _mapper;
        public UsersController(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //[HttpGet]
        //public IActionResult getUsers()
        //{
        //   var users = _repository.GetUsers();
        //    var usersDto = new List<UserDto>();
        //    foreach (var user in users) { 
        //        usersDto.Add(new UserDto
        //        {
        //            Id = user.Id,
        //            Name = user.Name,
        //            Address = $"{user.AddressNo} {user.Street} {user.City}"
        //        });
        //    }
        //    return Ok(usersDto);
        //}

        [HttpGet]
        public ActionResult<ICollection<UserDto>> getUsers()
        {
            var users = _repository.GetUsers();
            //var usersDto = new List<UserDto>();
            //foreach (var user in users)
            //{
            //    usersDto.Add(new UserDto
            //    {
            //        Id = user.Id,
            //        Name = user.Name,
            //        Address = $"{user.AddressNo} {user.Street} {user.City}"
            //    });
            //}
            var usersDto=_mapper.Map<ICollection<UserDto>>(users);
            return Ok(usersDto);
        }

        //[HttpGet("{id}")]
        //public IActionResult getUser(int id) {
        //    var user = _repository.GetUser(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    var userDto = _mapper.Map<UserDto>(user);
        //    return Ok(userDto);
        //}

        [HttpGet("{id}")]
        public ActionResult<UserDto> getUser(int id)
        {
            var user = _repository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }
    }
}
