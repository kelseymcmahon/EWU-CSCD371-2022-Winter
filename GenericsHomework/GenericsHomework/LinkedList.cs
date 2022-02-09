using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GenericsHomework;

public class LinkedList<T>
{
    public Node<T>? Head;
    public int Size { get; set; }

    public LinkedList()
    {
        Size = 0;
        Head = null;
    }

    public void Append(T value)
    {
        Node<T> newNode = new Node<T>(value) ?? throw new ArgumentNullException($"{nameof(Append)} can't add a null value");

        if(Size == 0 || Head == null)
        {
            Head = newNode;
        }

        else
        {
            if (Exists(value)) { throw new ArgumentException("Node already exists!"); }
            newNode.SetNext(Head.Next);
            Head.SetNext(newNode);
        }

        Size++;
    }

    public bool Exists(T value)
    {
        if(Head == null)
        {
            throw new ArgumentNullException($"{nameof(Exists)} method has a null head node");
        }

        Node<T> current = Head.Next;

        while (current != Head)
        {
            if(current.Value.Equals(value))
            {
                return true;
            }
            current = current.Next;
        }

        return false;
    }

    public void Clear()
    {
        if(Size == 0) { return; }
        Head?.SetNext(Head);
        Size = 1;
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

