using ManagementSystem.Entities;

namespace ManagementSystem.Services.IServices
{
    public interface IUserServices
    {
        Task<string> AddUserAsync(User user);

        Task<string> UpdateUserAsync(User user);

        Task<string> DeleteUserAsync(User user);

        Task<User> GetUserAsync(Guid Userid);

        Task<ICollection<User>> GetAllUsersAsync();


    }
}
