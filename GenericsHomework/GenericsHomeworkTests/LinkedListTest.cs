using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomeworkTests;

[TestClass]
public class LinkedListTest
{
    LinkedList<int> intList = new LinkedList<int>();
    LinkedList<string> stringList = new LinkedList<string>();

    [TestMethod]
    public void Append_AddsNewNode()
    {
        intList.Append(1);

        Assert.AreEqual<int>(1, intList.Size);
        Assert.AreEqual<int>(intList.Head.Value, 1);
    }

    [TestMethod]
    public void Exists_AddsNewNode()
    {

    }

    [TestMethod]
    public void Clear_AddsNewNode()
    {

    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Append_NullValue_ThrowsException()
    {
        stringList.Append(null!);
    }
}
