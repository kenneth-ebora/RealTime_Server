using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTime_Server.Models
{
    public class ChatData
    {
        public string Message { get; set; }
        public string User { get; set; }
    }

    public class ChatForSpecificDto : ChatData
    {
        public string ConnectionId { get; set; }
    }
}
