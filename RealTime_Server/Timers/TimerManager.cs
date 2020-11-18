using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RealTime_Server.Timers
{
    public class TimerManager
    {
        public Timer _timer { get; set; }
        public AutoResetEvent _autoResetEvent { get; set; }
        public Action _action { get; set; }
        public DateTime TimerStarted { get; set; }

        public TimerManager(Action action)
        {
            _action = action;
            _autoResetEvent = new AutoResetEvent(false);
            _timer = new Timer(Execute, _autoResetEvent, 1000, 2000);
            TimerStarted = DateTime.Now;
        }
        public void Execute(object stateInfo)
        {
            _action();

            if((DateTime.Now - TimerStarted).Seconds > 60)
            {
                _timer.Dispose();
            }
        }
    }
}
