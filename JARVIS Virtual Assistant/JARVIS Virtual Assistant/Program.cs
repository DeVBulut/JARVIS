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
            
            Console.WriteLine("Hello I am Jarvis");
            Console.WriteLine(Console.WindowWidth);
            Console.SetWindowSize(5000, 50);
            Console.WriteLine(Console.WindowWidth);
            Console.ReadLine();
            Console.SetWindowSize(50, 50);
        }
    }
}
