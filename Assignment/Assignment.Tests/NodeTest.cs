using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests
{
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
            Node<string> node1 = new("Kelsey");
            Node<string> node2 = new("Whitney");
            Node<string> node3 = new("Leona");

            node1.Append(node2);
            node2.Append(node3);

            Assert.AreEqual<Node<string>>(node1.Next, node2);
            Assert.AreEqual<Node<string>>(node2.Next, node3);
            Assert.AreEqual<Node<string>>(node3.Next, node1);
        }

    }
}
