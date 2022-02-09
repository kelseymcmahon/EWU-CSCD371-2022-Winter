using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomeworkTests;

[TestClass]
public class LinkedListTest
{
    [TestInitialize]
    public void TestInit()
    {
        LinkedList<int> intList = new LinkedList<int>();
        LinkedList<string> stringList = new LinkedList<string>();
    }

    [TestMethod]
    public void Append_AddsNewNode()
    {

    }

    [TestMethod]
    public void Exists_AddsNewNode()
    {

    }

    [TestMethod]
    public void Append_AddsNewNode()
    {

    }

    [TestMethod]
    public void Append_AddsNewNode()
    {

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Node_CreateNode_ThrowsNullException()
    {
        //Node<string> node = new(null);
    }
}
