namespace ScrumbledSignalR
{
    public class EventMessage
    {
        public UserConnection User { get; set; }    
        public string EventName { get; set; }

        public string Message { get;set; }
    }
}
