namespace ManagementSystem.Requests
{
    public class UpdateEvent
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public int Capacity { get; set; }

        public int TicketAmount { get; set; }

        public DateTime Date { get; set; }

    }
}
