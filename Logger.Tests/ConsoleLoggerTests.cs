using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class ConsoleLoggerTest
    {
        string message = "This is a standard message";
        BaseLogger? log;
        StringWriter stringWriter = new();

        [TestInitialize]
        public void TestInit()
        {
            log = LogFactory.CreateConsoleLogger(nameof(FileLoggerTests));
            Console.SetOut(stringWriter);
        }

        [TestMethod]
        public void Log_CheckConsoleLogMessageString_NotNull()
        {
            log?.Log(LogLevel.Error, message);
            Assert.IsNotNull(stringWriter.ToString());
        }

        [TestMethod]
        public void Log_CheckConsoleLogDisplay_CorrectDataDisplayed()
        {
            log?.Log(LogLevel.Error, message);

            Console.SetOut(stringWriter);
            string logMessage = stringWriter.ToString();
            string[] data = logMessage.Split(" | ");

            Assert.IsTrue(DateTime.TryParse(data[0], out DateTime date));
            Assert.AreEqual<string>(data[1], nameof(FileLoggerTests));
            Assert.AreEqual<string>(data[2], LogLevel.Error.ToString());
            Assert.AreEqual<string>(data[3], message + System.Environment.NewLine);
        }
    }
}
