using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeServiceTest
    {
        [TestMethod]
        public void GetJoke_String_Data()
        {
            JokeService service = new JokeService();
            
            Assert.IsInstanceOfType(service.GetJoke(), typeof(string));
        }

       [TestMethod]
        public void GetJoke_Null_CorrectData()
        {
            JokeService service = new JokeService();

            Assert.IsNotNull(service.GetJoke());
        }
    }
}
