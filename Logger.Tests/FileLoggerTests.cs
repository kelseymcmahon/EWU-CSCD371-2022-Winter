using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {

        string filePath = "test.txt";
        string message = "This is an standard message";

        [TestMethod]

        public void Log_CreateLogMessageString_NotNull()
        {
            //create the log file
            BaseLogger? log = LogFactory.CreateLogger(filePath);

            log?.Log(LogLevel.Error, message);

            string logMessage = File.ReadAllText(filePath);

            Assert.IsNotNull(logMessage);

            //delete log file after testing
            File.Delete(filePath);
                
        }

        //check date time in log method
        public void Log_CheckDateTime_CorrectDateTime()
        {
            //create the log file
            BaseLogger? log = LogFactory.CreateLogger(filePath);

            log?.Log(LogLevel.Error, message);

            //delete log file after testing
            File.Delete(filePath);

        }
    }
}
