using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lecture.Tests
{
    [TestClass]

    public class ISavableTests
    {

        [TestMethod]
        public void SimpleSave_GivenPerson_PersonString()
        {
            Person person = new ("Kelsey");

            //<string> a Generic that speicfies the data type for the AreEqual method. Always put the data type to make sure they are exactly the same.
            //You must compare two strings <string>
            Assert.AreEqual<string>("Name: Kelsey", person.ToText());

        }

        [TestMethod]
        public void SimpleSave_GivenAThing_ThingString()
        {
            Thing thing = new("Thing 1");
            Assert.AreEqual<string>("Name: Thing 1", thing.ToText());
        }

        [TestMethod]
        public void SimpleSave_GivenADocument_DocumentString()
        {
            //declaring the document object as a ISavable object here allows for the ISavable.MethodHere() option in the class
            ISavable document = new Document("Document 1");
            Assert.AreEqual<string>("Name: Document 1", document.ToText());
        }
    }
}
