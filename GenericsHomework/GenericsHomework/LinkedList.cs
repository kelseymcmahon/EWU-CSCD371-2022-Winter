using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;

public class LinkedList<T>
{
    public Node<T>? Head;
    public int size { get; set; }

    public LinkedList()
    {
        size = 0;
        Head = null;
    }

    public void Append(T value)
    {
        if (Exists(value)) { throw new ArgumentException("node already exists!"); }

        Node<T> newNode = new Node<T>(value) ?? throw new ArgumentNullException($"{nameof(Append)} can't add a null value");

        if(size == 0)
        {
            Head = newNode;
        }

        else
        {
            newNode.SetNext(Head!.Next);
            Head.SetNext(newNode);
        }

        size++;
    }

    public void Clear(Node<T> node)
    {
        Node<T> current = node;
    }

    public bool Exists(T value)
    {
        Node<T> current = Head!.Next;

        while (current != Head)
        {
            if(current.Value!.Equals(value))
            {
                return true;
            }
            current = current.Next;
        }

        return false;
    }

    public void PrintAll()
    {
        Console.WriteLine(Head!.ToString());
        Node<T> current = Head!.Next;

        while(current != Head)
        {
            Console.WriteLine(current.ToString());
            current = current.Next;
        }
    }
}

