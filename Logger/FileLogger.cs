using System;
using System.Collections.Generic;
using System.Text;

namespace Logger 
{
    internal class FileLogger : BaseLogger
    {
        public FileLogger(string filePath) 
        {


        }

        public override void Log(LogLevel logLevel, string message)
        {
            throw new NotImplementedException();
        }
    }
}
