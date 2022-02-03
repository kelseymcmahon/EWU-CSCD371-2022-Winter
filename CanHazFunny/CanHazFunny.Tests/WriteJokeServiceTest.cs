using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class WriteJokeServiceTest
    {
        string joke = "Did you hear about the claustrophobic astronaut? He just wanted a bit more space.";
        WriteJokeService? writeJokeService;
        StringWriter stringWriter = new();

        [TestInitialize]
        public void TestInit()
        {
            writeJokeService = new();
            Console.SetOut(stringWriter);
        }

        [TestMethod]
        public void WriteJokeToConsole_GetsJokeString_NotNull()
        {
            writeJokeService?.WriteJokeToConsole(joke);
            Assert.IsNotNull(stringWriter.ToString());
        }

        [TestMethod]
        public void WriteJokeToConsole_GetsJokeString_()
        {
            writeJokeService?.WriteJokeToConsole(joke);
            Assert.IsInstanceOfType(writeJokeService, typeof(IWriteJoke));
        }
    }
}
