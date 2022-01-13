using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture1.Tests
{
    [TestClass]
    public class PersonTests
    {
        //You dont need to specify the object you are creating after new if you are using a reference
        Person Person = new();

        string UserName = "kelseymc";
        string Password = "";

        //Your test should not be dependent on other tests, they should all run independently
        //This method will run once, and exactly once before all other methods
        //This should only appear once and should be formatted at the top of the test class
        [TestInitialize]
        public void Initialize()
        {
            Password = "HelloWorld";
        }

        [TestMethod]
        public void Login_GivenValidUserNameAndPassword_Success()
        {
            Person.Login(UserName, Password);

            bool success = Person.Login(UserName, Password);
            Assert.IsTrue(success);
        }

        [TestMethod]
        public void Login_GivenInvalidPassword_Failure()
        {
            Password = "InvalidPassword";
            Person.Login(UserName, Password);

            bool result = Person.Login(UserName, Password);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Login_GivenInvalidUserName_Failure()
        {
            UserName = "InvalidUserName";
            Person.Login(UserName, Password);

            bool result = Person.Login(UserName, Password);
            Assert.IsFalse(result);
        }
    }

}