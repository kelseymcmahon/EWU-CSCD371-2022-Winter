using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]
public class NodeTest
{
    [TestMethod]
    public void Node_NodeIsAdded_Success()
    {
        Node<string> node = new("Kelsey");

        Assert.AreEqual<string>(node.Value, "Kelsey");
        Assert.AreEqual<Node<string>>(node, node.Next);
    }

    [TestMethod]
    public void Append_NodeLinksAreCircular_Success()
    {
        Node<string> nodeList = new("Kelsey");
        nodeList.Append("Whitney");
        nodeList.Append("Leona");
        nodeList.Append("Gray");

        Node<string> currentNode = nodeList;
        Assert.AreEqual<string>(currentNode.Value, "Kelsey");

        currentNode = currentNode.Next;
        Assert.AreEqual<string>(currentNode.Value, "Gray");

        currentNode = currentNode.Next;
        Assert.AreEqual<string>(currentNode.Value, "Leona");

        currentNode = currentNode.Next;
        Assert.AreEqual<string>(currentNode.Value, "Whitney");

        currentNode = currentNode.Next;
        Assert.AreEqual<string>(currentNode.Value, nodeList.Value);
    }

    [TestMethod]
    public void Exists_ValuePresent_Success()
    {
        Node<string> nodeList = new("Kelsey");
        nodeList.Append("Whitney");
        nodeList.Append("Leona");
        nodeList.Append("Gray");

        Assert.IsTrue(nodeList.Exists("Kelsey"));
        Assert.IsTrue(nodeList.Exists("Gray"));
    }

    [TestMethod]
    public void GetEnumerator_ReturnsItems_Success()
    {
        Node<string> nodeList = new("Kelsey");
        nodeList.Append("Whitney");
        nodeList.Append("Leona");
        nodeList.Append("Gray");

        IEnumerator<Node<string>> stringEnumerator = nodeList.GetEnumerator();

        string getData;
        int count = 0;

        while (stringEnumerator.MoveNext())
        {
            getData = stringEnumerator.Current.Value;
            count++;
            Console.WriteLine(getData);
            Assert.IsNotNull(getData);
        }

        Assert.AreEqual<int>(count, nodeList.Count());
    }

    [TestMethod]
    public void ChildItems_ReturnsChildMaximum_Success()
    {
        Node<string> nodeList = new("Kelsey");
        nodeList.Append("Whitney");
        nodeList.Append("Leona");
        nodeList.Append("Gray");

        IEnumerable<Node<string>> list = nodeList.ChildItems(10);

        IEnumerator<Node<string>> stringEnumerator = list.GetEnumerator();

        string getData;
        int count = 0;

        while (stringEnumerator.MoveNext())
        {
            getData = stringEnumerator.Current.Value;
            count++;
            Console.WriteLine(getData);
            Assert.IsNotNull(getData);
        }

        Assert.AreEqual(list.Count(), count);
    }
}

