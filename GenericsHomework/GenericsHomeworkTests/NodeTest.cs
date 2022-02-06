using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsHomeworkTests
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void Node_CreateNode_NotNull()
        {
            Node node = new("Test");
        }
    }
}