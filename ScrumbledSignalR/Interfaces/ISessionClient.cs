namespace ScrumbledSignalR.Interfaces
{
    public interface ISessionClient
    {
        Task ReceiveUserJoinedMessage(EventMessage message);
    }
}
