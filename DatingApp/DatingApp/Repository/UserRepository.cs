using DatingApp.Data;
using DatingApp.IRepository;
using DatingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;

        public UserRepository( DataContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AppUser>> GetUserAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<AppUser> GetUserByIdAsync(int id)
        {
            return await context.Users.FindAsync(id);
        }

        public async Task<AppUser> GetUserByNameAsync(string username)
        {
            return await context.Users.SingleOrDefaultAsync(x => x.UserName == username);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}
