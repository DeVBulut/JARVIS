using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using NAudio.Wave;


namespace JARVIS_Virtual_Assistant
{
    internal class TimeLib
    {
        public void getTime()
        {
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;
            DispatcherTimer timer = new DispatcherTimer();
            
        }

        private Timer alarmTimer;

        public void SetAlarm(int hour, int minute)
        {
            DateTime currentTime = DateTime.Now;
            DateTime alarmTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, hour, minute, 0);

            if (alarmTime <= currentTime)
            {
                // The specified time has already passed for today, schedule it for tomorrow
                alarmTime = alarmTime.AddDays(1);
            }

            TimeSpan timeUntilAlarm = alarmTime - currentTime;

            // Set up a timer to execute when the specified time is reached
            alarmTimer = new Timer(AlarmCallback, null, timeUntilAlarm, Timeout.InfiniteTimeSpan);
        }

        private void AlarmCallback(object state)
        {
            // Code to execute when the alarm is triggered
            Console.WriteLine("Alarm Executing");
            PlayAlarmSound();
        }

        private readonly string mp3FilePath = "aaa.mp3"; 

        public void PlayAlarmSound()
        {
            string filePath = "C:\\Users\\devel\\Documents\\aaa.mp3";
            if (System.IO.File.Exists(filePath))
            {
                using (var audioFile = new AudioFileReader(filePath))
                using (var outputDevice = new WaveOutEvent())
                {
                    
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    Thread.Sleep((int)(audioFile.TotalTime.TotalMilliseconds));
                    Console.WriteLine("You got this far!");
                }
            }
            else { Console.WriteLine("File not there"); }
        }
    }
}
