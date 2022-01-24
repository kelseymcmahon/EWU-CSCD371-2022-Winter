using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]

        public void Log_CreateMessageLogString()
        {
            string fileName = "test.txt";
            LogFactory log = new LogFactory(fileName);
            string message = "This is an error message";

            log.Log(LogLevel.Error, message);

            Assert.IsInstanceOfType(log, typeof(string));
                
        }
    }
}
