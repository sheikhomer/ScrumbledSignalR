using Microsoft.AspNetCore.SignalR;
using ScrumbledSignalR.Interfaces;

namespace ScrumbledSignalR.Hubs
{
    public class SessionHub : Hub<ISessionClient>
    {
        public async Task JoinSession(UserConnection userConnection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, userConnection.SessionId);
            var message = new EventMessage
            {
                User = userConnection,
                EventName = nameof(EventName.UserJoined),
            };
            await Clients.Group(userConnection.SessionId).ReceiveUserJoinedMessage(message);
        }
    }
}
