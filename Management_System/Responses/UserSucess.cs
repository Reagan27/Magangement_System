namespace ManagementSystem.Responses
{
    public class UserSucess
    {
        public int code { get; set; }
        public string Message { get; set; } = string.Empty;

        public UserSucess(int code, string Message) { 
        
            this.code = code;
            this.Message = Message;
        
        }

    }
}
