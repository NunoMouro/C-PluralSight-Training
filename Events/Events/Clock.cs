using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void SecondChangeHandler(
            object clock,
            TimeInfoEventArg timeInfo);

        public event SecondChangeHandler SecondChanged;
        public void Run()
        {
            for (; ; )
            {
                System.Threading.Thread.Sleep(100);
                DateTime now = DateTime.Now;
                if(now.Second != second)
                {
                    TimeInfoEventArg timeInfoEventArg =
                        new TimeInfoEventArg(
                            now.Hour,
                            now.Minute,
                            now.Second);

                    if (SecondChanged != null)
                    {
                        SecondChanged(this, TimeInfoEventArg);
                    }
                }
            }
        }
    }
}
