using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Next = this;
        }

        public void Append(Node<T> NewNode)
        {
            Node<T> temp = this.Next;
            Next = NewNode;
            NewNode.Next = temp;
        }

        public IEnumerable<T> NodeList
        {
            get { return this;}
        }

        public IEnumerable<T> ChildItems(int maximum)
        {

        }
}
