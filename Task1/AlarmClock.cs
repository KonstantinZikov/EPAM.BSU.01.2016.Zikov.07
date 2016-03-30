using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public class AlarmClock
    {
        public void Set(TimeSpan timeSpan)
        {
            Task.Run(delegate
            {
                Thread.Sleep(timeSpan);
                OnWakeUp(this, new EventArgs());              
            });

        }

        public void OnWakeUp(object sender, EventArgs e)
            => WakeUp(sender,e);

        public event EventHandler WakeUp = delegate { };
    }
}
