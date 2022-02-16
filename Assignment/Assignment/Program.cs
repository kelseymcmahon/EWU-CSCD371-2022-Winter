using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;

public class Program
{
    public static void Main()
    {
        SampleData data = new SampleData();

        foreach (string item in data.CsvRows)
        {
            Console.WriteLine(item);    
        }

        //string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

        //Console.WriteLine(path);
    }

}

