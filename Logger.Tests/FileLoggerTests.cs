using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {

        string filePath = "test.txt";
        string message = "This is an standard message";

        [TestMethod]

        public void Log_CreateMessageLogString()
        {
            //create the log file
            BaseLogger? log = LogFactory.CreateLogger(filePath);

            log?.Log(LogLevel.Error, message);

            //need to check the line written on the file from calling the Log method
            //Assert.IsInstanceOfType(log, typeof(string));

            //delete log file after testing
            File.Delete(filePath);
                
        }

        //check date time in log method
        //
    }
}
