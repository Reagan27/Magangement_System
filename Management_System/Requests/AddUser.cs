using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ManagementSystem.Requests
{
        public class AddUser
        {
            [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string UserEmail { get; set; } = string.Empty;
        [Required]
        public int PhoneNumber { get; set; }
    }
    
}
