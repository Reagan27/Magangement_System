namespace ManagementSystem.Responses
{
    public class EventSuccess
    {
        public int code { get; set; }
        public string Message { get; set; } = string.Empty;

        public EventSuccess(int code, string Message)
        {

            this.code = code;
            this.Message = Message;

        }
    }
}
