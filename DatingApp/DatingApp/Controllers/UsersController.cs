using DatingApp.Data;
using DatingApp.IRepository;
using DatingApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository userRepository;

        public UsersController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
        {
            return Ok(await userRepository.GetUserAsync());
        }

        //[HttpGet("{id}")]
        //public async Task<ActionResult<AppUser>> getuser(int id)
        //{
        //    return await userRepository.GetUserByIdAsync(id);
        //}
        [HttpGet("{username}")]
        public async Task<ActionResult<AppUser>> GetUser(string username)
        {
            return await userRepository.GetUserByNameAsync(username);
        }
    }
}
