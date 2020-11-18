using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RealTime_Server.Data;
using RealTime_Server.Hubs;
using RealTime_Server.Models;
using RealTime_Server.Timers;

namespace RealTime_Server.Controllers
{
    [Route("api/[controller]")]
    public class ChartController : ControllerBase
    {
        public readonly IHubContext<ChartHub> _hub;

        public ChartController(IHubContext<ChartHub> hub)
        {
            _hub = hub;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferchartdata", DataManager.GetData()));

            return Ok(new { Message = "Request Completed" });
        }

        [HttpPost]
        public IActionResult Post([FromBody] ChatData data)
        {
            _hub.Clients.All.SendAsync("sendmessage", data);
            return Ok(data);
        }
    }
}
