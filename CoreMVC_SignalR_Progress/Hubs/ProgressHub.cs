using Microsoft.AspNetCore.SignalR;

namespace CoreMVC_SignalR_Progress.Hubs
{
    public class ProgressHub : Hub
    {
        /// <summary>
        /// 連線事件
        /// </summary>
        /// <returns></returns>
        public override async Task OnConnectedAsync()
        {
            // 回傳連線ID
            await Clients.Client(Context.ConnectionId).SendAsync("SetHubConnId", Context.ConnectionId);

            await base.OnConnectedAsync();
        }
    }
}
