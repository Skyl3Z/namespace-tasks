using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Project.Tools
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void Warn(string message)
        {
            Console.WriteLine("WARNING: " + message);
        }

        public static void Error(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }
    }
}
