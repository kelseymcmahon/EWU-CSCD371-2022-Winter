namespace Lecture1.Tests
{
    public class Person
    {
        //declare valid usernames and passwords 

        //This is called a tuple. when declaring a tuple, make sure to include a reference name for the data type
        (string UserName, string Password)[] Credentials = new[]
        {
            ("kelseymc", "HelloWorld"),
        };

        public bool Login(string userName, string password)
        {
            return (userName, password) == Credentials[0];
        }
    }
}