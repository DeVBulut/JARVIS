using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace JARVIS_Virtual_Assistant
{
    internal class TimeLib
    {
        public void getTime()
        {
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 15); // sets it to 5 minutes
            timer.Start();
            if (currentDate.Hour == 9 && currentDate.Minute == 30)
            {
                Console.WriteLine("Ello");
            }
        }

        public string setAlarm(int hour, int minute)
        {
            DateTime currentDate = DateTime.Now;
            while (true) {
                currentDate = DateTime.Now;
                if (currentDate.Hour == hour && currentDate.Minute == minute)
                {
                    return "Alarm Executing";
                }
            }
        }

        
    }
}
