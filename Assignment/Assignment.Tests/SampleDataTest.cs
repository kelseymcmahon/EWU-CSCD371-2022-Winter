using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTest
{
    [TestMethod]
    public void CvsRows_GetData_Success()
    {
        SampleData data = new();

        foreach (string item in data.CsvRows)
        {
            Console.WriteLine(item);
            Assert.IsNotNull(item);
        }
    }

    [TestMethod]
    public void CvsRows_GetCorrectData_Success()
    {
        SampleData data = new();

        foreach (string item in data.CsvRows)
        {
            Assert.IsNotNull(item);
        }
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_GetCorrectData_Success()
    {
        SampleData data = new();

        foreach (string item in data.GetUniqueSortedListOfStatesGivenCsvRows())
        {
            Console.WriteLine(item);
            Assert.IsNotNull(item);
        }
    }

   [TestMethod]
    public void GetAggregateSortedListOfStatesUsingCsvRows_GetCorrectData_Success()
    {
        SampleData data = new();

        Console.WriteLine(data.GetAggregateSortedListOfStatesUsingCsvRows());
        Assert.IsNotNull(data.GetAggregateSortedListOfStatesUsingCsvRows());
        Assert.IsInstanceOfType(data.GetAggregateSortedListOfStatesUsingCsvRows(), typeof(string));
    }
}

