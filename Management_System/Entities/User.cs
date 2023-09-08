namespace MaagementSystem.Entities
{
    public class User
    {
        public Guid UserId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string UserEmail { get; set; } = string.Empty;

        public int PhoneNumber  { get; set; }

        public IEnumerable<Event> Events { get; set; } = new List<Event>();


    }
}
