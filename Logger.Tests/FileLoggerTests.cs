using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        string filePath = "test.txt";
        string message = "This is a standard message";
        BaseLogger? log;

        [TestInitialize]
        public void TestInit()
        {
            LogFactory.ConfigureFileLogger(filePath);
            log = LogFactory.CreateLogger(nameof(FileLoggerTests));
        }

        [TestCleanup]
        public void TestClean()
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

        [TestMethod]
        public void Log_CheckLog_CorrectData()
        {
            log?.Log(LogLevel.Error, message);

            string logMessage = File.ReadAllText(filePath);
            string[] data = logMessage.Split(" | ");

            Assert.IsTrue(DateTime.TryParse(data[0], out DateTime date));
            Assert.AreEqual<string>(data[1], nameof(FileLoggerTests));
            Assert.AreEqual<string>(data[2], LogLevel.Error.ToString());
            Assert.AreEqual<string>(data[3], message);
        }
    }
}
