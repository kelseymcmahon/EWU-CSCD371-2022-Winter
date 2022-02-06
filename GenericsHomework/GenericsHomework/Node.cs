using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;

public class Node<TValue>
{
    TValue? Value;
    private Node<TValue> Next;

    public Node(TValue value)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

