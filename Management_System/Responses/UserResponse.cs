namespace ManagementSystem.Responses
{
    public class UserResponse
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;

        public string UserEmail { get; set; } = string.Empty;

        public int PhoneNumber { get; set; }

    }
}
