using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        string filepath = "test.txt";

        [TestInitialize]
        public void TestInit()
        {
            LogFactory.ResetConfiguration();
        }

        [TestCleanup]
        public void TestClean()
        {
            File.Delete(filepath);
        }
        
        [TestMethod]
        public void CreateLogger_CreatesNullWhenUnconfigured()
        {
            Assert.IsNull(LogFactory.CreateLogger(nameof(LogFactoryTests)));
        }
        
        [TestMethod]
        public void CreateLogger_PassesFilepathString()
        {
            LogFactory.ConfigureFileLogger(filepath);
            BaseLogger? logger = LogFactory.CreateLogger(nameof (LogFactoryTests));
            logger?.Log(LogLevel.Warning, "Test Message");
            Assert.IsTrue(File.Exists(filepath));
        }
       
        [TestMethod]
        public void ResetConfiguration_SetsConfiguredPathToNull()
        {
            LogFactory.ConfigureFileLogger(filepath);
            LogFactory.ResetConfiguration();
            Assert.IsNull(LogFactory.CreateLogger(nameof(LogFactoryTests)));

        }
    }
}
