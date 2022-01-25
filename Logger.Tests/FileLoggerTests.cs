using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {

        string filePath = "test.txt";
        string message = "This is an standard message";
        string loggerName = "TestFileLogger";

        [TestInitialize]
        void TestInit()
        {
            LogFactory.ConfigureFileLogger(filePath);
        }

        [TestCleanup]
        void TestClean()
        {
            File.Delete(filePath);
        }


        [TestMethod]

        public void Log_CreateLogMessageString_NotNull()
        {
            LogFactory.ConfigureFileLogger(filePath);
            //create the log file
            BaseLogger? log = LogFactory.CreateLogger(loggerName);

            log?.Log(LogLevel.Error, message);

            string logMessage = File.ReadAllText(filePath);

            Assert.IsNotNull(logMessage);
                
        }

        //check date time in log method
        [TestMethod]
        public void Log_CheckLog_CorrectData()
        {
            //create the log file
            BaseLogger? log = LogFactory.CreateLogger(filePath);

            log?.Log(LogLevel.Error, message);

            //delete log file after testing
            File.Delete(filePath);

        }
    }
}
