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

    [TestMethod]
    public void Append_AddsNewNode()
    {
        intList.Append(1);

        Assert.AreEqual<int>(1, intList.Size);
        Assert.AreEqual<int>(intList.Head!.Value, 1);
    }

    [TestMethod]
    public void Exists_ChecksNode_True()
    {
        intList.Append(1);
        Assert.IsTrue(intList.Exists(1));
    }

    [TestMethod]
    public void Exists_ChecksNode_False()
    {
        intList.Append(1);
        Assert.IsFalse(intList.Exists(2));
    }

    [TestMethod]
    public void Clear_ListIsCleared()
    {
        intList.Append(1);
        intList.Append(2);
        intList.Append(3);
        intList.Clear();
        Assert.AreEqual<int>(intList.Size, 1);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Append_NullValue_ThrowsException()
    {
        stringList.Append(null!);
    }
}
