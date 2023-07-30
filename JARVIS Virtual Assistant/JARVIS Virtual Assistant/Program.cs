using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARVIS_Virtual_Assistant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginManager loginManager = new LoginManager();
            //loginManager.logType;  >> Variable that stores the type of Login.


            //Execute Login Sequence
            try { loginManager.Intro(); }
            catch (Exception e) { if (loginManager.logType == 2) { Console.WriteLine("$$$ Error Code : " + e); } }
            Console.ReadLine();
        }
    }
}
