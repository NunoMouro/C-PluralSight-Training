using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Log
    {
        public void Subscribe (Clock clock)
        {
            clock.SecondChanged += LogTime;
        }
        
        public void LogTime(object o, TimeInfoEventArg e)
        {
            Console.WriteLine($"Logging {e.Hour.ToString()} ");
        }
    }
}
