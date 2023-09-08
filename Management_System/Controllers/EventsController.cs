using AutoMapper;
using ManagementSystem.Entities;
using ManagementSystem.Requests;
using ManagementSystem.Responses;
using ManagementSystem.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers
{
    [Route("Events")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEventServices _eventSevice;

        public EventsController(IEventServices service, IMapper mapper)
        {
            _mapper = mapper;
            _eventSevice = service;
        }

        [HttpPost]
        public async Task<ActionResult<EventSuccess>> AddEvent(AddEvent newEvent)
        {
            var _event = _mapper.Map<Event>(newEvent);
            var res = await _eventSevice.AddEventAsync(_event);
            return CreatedAtAction(nameof(AddEvent), new EventSuccess(201, res));

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventResponse>>> GetAllEventsAsync()
        {
            var response = await _eventSevice.GetAllEventsAsync();
            var _events = _mapper.Map<IEnumerable<EventResponse>>(response);
            return Ok(_events);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventResponse>> GetEvent(Guid id)
        {
            var response = await _eventSevice.GetEventAsync(id);
            var _event = _mapper.Map<EventResponse>(response);
            return Ok(_event);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EventSuccess>> UpdateEvent(Guid id, AddEvent UpdatedEvent)
        {
            var response = await _eventSevice.GetEventAsync(id);
            if (response == null)
            {
                return NotFound(new EventSuccess(404, "Event Does Not Exist"));
            }
            //update
            var updated = _mapper.Map(UpdatedEvent, response);
            var res = await _eventSevice.UpdateEventAsync(updated);
            return Ok(new EventSuccess(204, res));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EventSuccess>> DeleteEvent(Guid id)
        {
            var response = await _eventSevice.GetEventAsync(id);
            if (response == null)
            {
                return NotFound(new EventSuccess(404, "Event Does Not Exist"));
            }
            //delete

            var res = await _eventSevice.DeleteEventAsync(response);
            return Ok(new EventSuccess(204, res));
        }

    }
}
