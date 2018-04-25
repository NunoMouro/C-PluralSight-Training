using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class DigitalClock
    {
        public void Subscribe(Clock theClok)
        {
            theClok.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArg e)
        {
            Console.WriteLine($"Current Time: {e.Hour.ToString()}");
        }
    }
}
