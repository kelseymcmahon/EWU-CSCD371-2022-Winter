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

        Console.WriteLine($"4 exists: {list.Exists(4)}");

        LinkedList<string> list2 = new LinkedList<string>();

        list2.Append("Kelsey");
        list2.Append("Leona");
        list2.Append("Aaron");
        list2.Append("Gray");

        Console.WriteLine($"4 exists: {list2.Exists("4")}");

        list2.Append("Kelsey");
    }
}
