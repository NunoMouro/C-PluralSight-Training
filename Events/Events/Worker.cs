using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Worker
    {
        public void Work()
        {
            Clock clock = new Clock();
            DigitalClock digitalClock = new DigitalClock();
            digitalClock.Subscribe(clock);
            Log.Subscribe(clock);
        }
    }
}
