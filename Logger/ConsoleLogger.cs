using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    internal class ConsoleLogger : BaseLogger
    {
        public override void Log(LogLevel logLevel, string message)
        {
            string log = DateTime.Now.ToString() + " | " + this.Name + " | " + logLevel.ToString() + " | " + message + System.Environment.NewLine;
            Console.Write(log);
        }

        
    }
}
