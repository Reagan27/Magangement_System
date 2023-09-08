using ManagementSystem.Entities;

namespace EvenManagement.Services.IServices
{
    public interface IEventServices
    {
        Task<string> AddEventAsync(Event _event);

        Task<string> UpdateEventAsync(Event _event);

        Task<string> DeleteEventAsync(Event _event);

        Task<Event> GetEventAsync(Guid id);

        Task<ICollection<Event>> GetAllEventsAsync();
    }
}
