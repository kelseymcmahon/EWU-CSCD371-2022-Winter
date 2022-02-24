using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;

public class Node<T> : IEnumerable<Node<T>> where T : notnull
{
    public T Value { get; set; }
    public Node<T> Next { get; set; }

    public Node(T value)
    {
        if (value is null) throw new ArgumentNullException("value cant be null");

        Value = value;
        Next = this;
    }

    public void Append(T Value)
    {
        if (Exists(Value))
        {
            throw new InvalidOperationException("Can't append duplicate values");
        }

        Node<T> newNode = new(Value);
        Node<T> temp = this.Next;

        Next = newNode;
        newNode.Next = temp;
    }

    public bool Exists([DisallowNull] T Value)
    {
        if (this.Value.Equals(Value)) return true;

        else if (this.Next == this) return false;

        Node<T> cursor = this.Next;

        while (cursor != this)
        {
            if (cursor.Value.Equals(Value)) return true;
            cursor = cursor.Next;
        }

        return false;
    }

    public IEnumerator<Node<T>> GetEnumerator()
    {
        Node<T> current = this;

        do
        {
            yield return current;
            current = current.Next;
        }
        while (current != this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Node<T>> ChildItems(int maximum)
    {
        List<Node<T>> list = new();
        
        int count = 0;
        Node<T> current = this;

        do
        {
            list.Add(current);
            current = current.Next;
            count++;
        }
        while (count < maximum);

        return list;
    }
}
