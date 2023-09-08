using AutoMapper;
using EvenManagement.Entities;
using EvenManagement.Requests;
using EvenManagement.Responses;
using EvenManagement.Services;
using EvenManagement.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserServices _userSevices;

        public UserController(IUserServices service, IMapper mapper)
        {
            _mapper = mapper;
            _userSevices = service;
        }

        [HttpPost]
        public async Task<ActionResult<UserSucess>> AddUser(AddUser newUser)
        {
            var user = _mapper.Map<User>(newUser);
            var res = await _userSevices.AddUserAsync(user);
            return CreatedAtAction(nameof(AddUser), new UserSucess(201, res));

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserResponse>>> GetAllUsersAsync()
        {
            var response = await _userSevices.GetAllUsersAsync();
            var users = _mapper.Map<IEnumerable<UserResponse>>(response);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetUser(Guid id)
        {
            var response = await _userSevices.GetUserAsync(id);
            var user = _mapper.Map<UserResponse>(response);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserSucess>> UpdateUser(Guid id, AddUser UpdatedUser)
        {
            var response = await _userSevices.GetUserAsync(id);
            if (response == null)
            {
                return NotFound(new UserSucess(404, "User Does Not Exist"));
            }
            //update
            var updated = _mapper.Map(UpdatedUser, response);
            var res = await _userSevices.UpdateUserAsync(updated);
            return Ok(new UserSucess(204, res));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UserSucess>> DeleteUser(Guid id)
        {
            var response = await _userSevices.GetUserAsync(id);
            if (response == null)
            {
                return NotFound(new UserSucess(404, "User Does Not Exist"));
            }
            //delete

            var res = await _userSevices.DeleteUserAsync(response);
            return Ok(new UserSucess(204, res));
        }




    }
}
