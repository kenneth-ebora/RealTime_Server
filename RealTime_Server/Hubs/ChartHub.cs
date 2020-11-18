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

        public async Task SendMessage(ChatData data) =>
            await Clients.All.SendAsync("chatdata", data);

    }
}
