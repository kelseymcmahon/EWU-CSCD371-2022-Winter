using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Logger 
{
    //Create a FileLogger that derives from BaseLogger
    public class FileLogger : BaseLogger
    {
        public string FilePath;

        public FileLogger(string filePath)
        {
            FilePath = filePath;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            string log = DateTime.Now.ToString() + " | " + this.Name + " | " + logLevel.ToString() + " | " + message+System.Environment.NewLine;

            File.AppendAllText(FilePath, log);
        }
    }
}
