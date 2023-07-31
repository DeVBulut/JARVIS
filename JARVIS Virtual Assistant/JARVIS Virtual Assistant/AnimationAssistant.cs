using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JARVIS_Virtual_Assistant
{
    internal class AnimationAsisstant
    {
        public void LoadAnimation(int cycles)
        {
            slowText("connecting ", 30, false, 30);

            int cycle = cycles * 3;
            for (int i = 0; i < cycle; i++)
            {
                string[] LoadChars = { "|", "/", "-", "\\", };
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(LoadChars[j]);
                    Thread.Sleep(80);
                    Console.Write("\b"); //backspace for ASCII
                }
            }
            Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r"); //clean the line
        }



        public void slowText(string rawText)
        {
            for (int i = 0; i < rawText.Length; i++)
            {
                Console.Write(rawText[i]);
                Thread.Sleep(25);
            }
        }


        
        public void slowText(string rawText, int timeGap, bool leaveGap, int WaitTime)
        {

            for (int i = 0; i < rawText.Length; i++)
            {
                Console.Write(rawText[i]);
                Thread.Sleep(timeGap);
            }

            if (leaveGap) { Console.WriteLine(); }

            Thread.Sleep(WaitTime);
        }
    }
}
