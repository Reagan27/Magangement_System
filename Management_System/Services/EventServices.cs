using ManagementSystem.Data;
using ManagementSystem.Entities;
using ManagementSystem.Services.IServices;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Services
{
    public class EventServices : IEventServices
    {
        //DependencyInjection DbContext
        private AppDbContext _context;
        public EventServices(AppDbContext _appDbContext)
        {

            _context = _appDbContext;

        }
        public async Task<string> AddEventAsync(Event _event)
        {
            _context.Events.Add(_event);
            await _context.SaveChangesAsync();
            return "Event Created Successfully";
        }

        public async Task<string> DeleteEventAsync(Event _event)
        {
            _context.Events.Remove(_event);
            await _context.SaveChangesAsync();
            return "Event Deleted Successfully";
        }

        public async Task<ICollection<Event>> GetAllEventsAsync()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> GetEventAsync(Guid Id)
        {
            return await _context.Events.Where(e => e.Id == Id).FirstOrDefaultAsync();

        }

        public async Task<string> UpdateEventAsync(Event _event)
        {
            _context.Events.Update(_event);
            await _context.SaveChangesAsync();
            return "Evented Updated Succesfully";
        }
    }
}
