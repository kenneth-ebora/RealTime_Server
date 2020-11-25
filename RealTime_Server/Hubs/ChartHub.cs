using Microsoft.AspNetCore.SignalR;
using RealTime_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTime_Server.Hubs
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data) =>
            await Clients.All.SendAsync("broadcastchartdata", data);

        public async Task NotifySelf(string message) =>
            await Clients.Caller.SendAsync("SelfNotifs", message);

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnected", Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            await Clients.All.SendAsync("UserDisconnected", Context.ConnectionId);
            await base.OnDisconnectedAsync(ex);
        }

    }
}
