using DatingApp.Data;
using DatingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext context;

        public UsersController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
        {
            return await context.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await context.Users.FindAsync(id);
        }
    }
}
