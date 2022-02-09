using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

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

        Console.WriteLine($"List size: {list.Size}");

        Console.WriteLine($"4 exists: {list.Exists(4)}");

        LinkedList<string> list2 = new LinkedList<string>();

        list2.Append("Kelsey");
        list2.Append("Leona");
        list2.Append("Aaron");
        list2.Append("Gray");
        list2.Append("Kelsey");

        Console.WriteLine($"4 exists: {list2.Exists("4")}");

        Console.WriteLine("List 2:");
        list2.PrintAll();

        list2.Clear();

        Console.WriteLine("List 2 after clear:");
        list2.PrintAll();

        Console.WriteLine($"List 2 size: {list2.Size}");

        
    }
}
