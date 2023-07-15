using DatingApp.Models;

namespace DatingApp.IRepository
{
    public interface IUserRepository
    {
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUserAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByNameAsync(string username);
    }
}
