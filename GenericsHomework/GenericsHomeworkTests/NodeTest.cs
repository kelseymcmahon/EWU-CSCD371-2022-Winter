using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomeworkTests;

[TestClass]
public class NodeTest
{
    [TestMethod]
    public void Node_CreateNode_NotNull()
    {
        Node<string> node = new("Test");
        Assert.IsNotNull(node);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Node_CreateNode_ThrowsNullException()
    {
        Node<string> node = new(null);
    }
}
