using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework;

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();

        list.Append(1);
        list.Append(2);
        list.Append(3);
        list.Append(4);
        list.Append(5);

        list.PrintAll();

        Console.WriteLine($"List size: {list.size}");
    }
}
