﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace JARVIS_Virtual_Assistant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginManager loginManager = new LoginManager();
            //loginManager.logType;  >> Variable that stores the type of Login.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            Console.WriteLine("\r\n   `7MMF'    db      `7MM\"\"\"Mq.`7MMF'   `7MF'`7MMF' .M\"\"\"bgd \r\n     MM     ;MM:       MM   `MM. `MA     ,V    MM  ,MI    \"Y \r\n     MM    ,V^MM.      MM   ,M9   VM:   ,V     MM  `MMb.     \r\n     MM   ,M  `MM      MMmmdM9     MM.  M'     MM    `YMMNq. \r\n     MM   AbmmmqMA     MM  YM.     `MM A'      MM  .     `MM \r\n(O)  MM  A'     VML    MM   `Mb.    :MM;       MM  Mb     dM \r\n Ymmm9 .AMA.   .AMMA..JMML. .JMM.    VF      .JMML.P\"Ybmmd\" \r\n ");
            Console.WriteLine("──────────────────────────────────────────────────────────────");
            //Execute Login Sequence
            //TimeZone localZone = TimeZone.CurrentTimeZone;
            //DateTime currentDate = DateTime.Now;
            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = new TimeSpan(0, 5, 0); // sets it to 5 minutes
            //timer.Tick += new EventHandler(timer_Tick);
            //timer.Start();
            //if (currentDate.Hour == 11 && currentDate.Minute == 29)
            //{
            //    Console.WriteLine("Ello");
            //}
            try { //loginManager.Intro();
                ListDesigner _listDesigner = new ListDesigner();
                _listDesigner.createList("tabletable", "column1", "int");
            }
            catch (Exception e) { if (loginManager.logType == 2) { Console.WriteLine("$$$ Error Code : " + e); } }
            Console.ReadLine();
        }
    }
}
