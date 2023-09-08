using ManagementSystem.Data;
using ManagementSystem.Entities;
using ManagementSystem.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Services
{
    public class UserServices : IUserServices

    {
        //DependencyInjection DbContext
        private AppDbContext _context;
        public UserServices(AppDbContext _appDbContext) {

            _context = _appDbContext;

        }
        public async Task<string> AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return "User Created Successfully";
        }

        public async Task<string> DeleteUserAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return "User Deleted Successfully";
        }

        public async Task<ICollection<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserAsync(Guid Userid)
        {
            return await _context.Users.Where(u => u.UserId == Userid).FirstOrDefaultAsync();

        }

        public async Task<string> UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return "User Updated Succesfully";
        }
    }
}
