using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Requests
{
    public class AddEvent
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string Location { get; set; } = string.Empty;
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int TicketAmount { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
