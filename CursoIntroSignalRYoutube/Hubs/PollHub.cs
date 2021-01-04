using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CursoIntroSignalRYoutube.Hubs
{
    public class PollHub : Hub
    {
        public async Task SendMessage(string user, string message, string myChannelId, string myChannelVal)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, myChannelId, myChannelVal).ConfigureAwait(false);
        }
    }
}
