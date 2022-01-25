using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {

        string filePath = "test.txt";
        string message = "This is an standard message";
        BaseLogger? log;

        [TestInitialize]
        void TestInit()
        {
            LogFactory.ConfigureFileLogger(filePath);
            log = LogFactory.CreateLogger(nameof(FileLoggerTests));
        }

        [TestCleanup]
        void TestClean()
        {
            File.Delete(filePath);
        }


        [TestMethod]

        public void Log_CreateLogMessageString_NotNull()
        {

            log?.Log(LogLevel.Error, message);

            string logMessage = File.ReadAllText(filePath);

            Assert.IsNotNull(logMessage);
                
        }

        //check date time in log method
        [TestMethod]
        public void Log_CheckLog_CorrectData()
        {

            log?.Log(LogLevel.Error, message);

            File.Delete(filePath);

        }
    }
}
