using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomeworkTests;

[TestClass]
public class LinkedListTest
{
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Node_CreateNode_ThrowsNullException()
    {
        //Node<string> node = new(null);
    }
}
