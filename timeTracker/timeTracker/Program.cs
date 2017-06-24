using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeTracker
{
    class Tracker
    {
        static void Main(string[] args)
        {
            string path = @"C:\timetracker.txt";

            TextWriter tw = new StreamWriter(path, true);

            string userInput = "";

            Console.WriteLine("Enter start/stop time");
            while(userInput != "close")
            {
                userInput = Console.ReadLine();
                tw.WriteLine(userInput);
            }

            tw.Close();
            
        }
    }
}
