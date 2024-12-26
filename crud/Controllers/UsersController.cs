using AutoMapper;
using crud.Models;
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

        //[HttpGet]
        //public ActionResult<ICollection<UserDto>> getUsers()
        //{
        //    var users = _repository.GetUsers();
        //    //var usersDto = new List<UserDto>();
        //    //foreach (var user in users)
        //    //{
        //    //    usersDto.Add(new UserDto
        //    //    {
        //    //        Id = user.Id,
        //    //        Name = user.Name,
        //    //        Address = $"{user.AddressNo} {user.Street} {user.City}"
        //    //    });
        //    //}
        //    var usersDto=_mapper.Map<ICollection<UserDto>>(users);
        //    return Ok(usersDto);
        //}

        [HttpGet]
        public ActionResult<ICollection<UserDto>> getUsers([FromQuery]string? type, [FromQuery]string? search)
        {
            var users = _repository.GetAllUsers(type, search);
            var usersDto = _mapper.Map<ICollection<UserDto>>(users);
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

        [HttpGet("{id}", Name="GetUser")]
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

        [HttpPost]
        public ActionResult<UserDto> createUser(CreateUserDto user)
        {
            var userEntity = _mapper.Map<User>(user);
            var newUser = _repository.AddUser(userEntity);
            var returnUser = _mapper.Map<UserDto>(newUser);
            return CreatedAtRoute("GetUser", new {id = returnUser.Id}, returnUser);
        }
    }
}
