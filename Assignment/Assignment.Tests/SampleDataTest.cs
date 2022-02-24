using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTest
{
    IEnumerator<string>? stringEnumerator;
    IEnumerator<IPerson>? personEnumerator;
    IEnumerator<(string, string)>? stringToupleEnumerator;
    SampleData data = new();

    [TestMethod]
    public void CvsRows_GetData_Success()
    {
        Assert.IsNotNull(data.CsvRows);
        Assert.AreEqual<int>(50, data.CsvRows.Count());
    }

    [TestMethod]
    public void CvsRows_GetCorrectData_Success()
    {
        stringEnumerator = data.CsvRows.GetEnumerator();
        string getData;

        while(stringEnumerator.MoveNext())
        {
            getData = stringEnumerator.Current;
            Console.WriteLine(getData);
            Assert.IsNotNull(getData);
        }
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_GetCorrectData_Success()
    {
        stringEnumerator = data.GetUniqueSortedListOfStatesGivenCsvRows().GetEnumerator();
        string state;

        while(stringEnumerator.MoveNext())
        {
            state = stringEnumerator.Current;
            Console.WriteLine(state);
            Assert.IsNotNull(state);
        }

        //Include a test that uses LINQ to verify the data is sorted correctly (do not use a hardcoded list).
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_CheckListDataWithHardcodedData_Success()
    {
        IEnumerable<string> newData = data.CsvRows;

        IEnumerable<string> stateQuery =
                from line in newData
                where line.Contains("Spokane")
                select line;

        IEnumerable<string> spokaneData = stateQuery.Distinct().ToList();

        stringEnumerator = spokaneData.GetEnumerator();
        string state;

        while (stringEnumerator.MoveNext())
        {
            state = stringEnumerator.Current;
            Console.WriteLine(state);
            Assert.IsTrue(state.Contains("Spokane"));
        }
    }

   [TestMethod]
    public void GetAggregateSortedListOfStatesUsingCsvRows_GetCorrectData_Success()
    {
        Console.WriteLine(data.GetAggregateSortedListOfStatesUsingCsvRows());
        Assert.IsNotNull(data.GetAggregateSortedListOfStatesUsingCsvRows());
        Assert.IsInstanceOfType(data.GetAggregateSortedListOfStatesUsingCsvRows(), typeof(string));
    }

    [TestMethod]
    public void People_GetCorrectData_Success()
    {
        personEnumerator = data.People.GetEnumerator();
        IPerson getPerson;

        while(personEnumerator.MoveNext())
        {
            getPerson = personEnumerator.Current;
            Console.WriteLine(getPerson.ToString());
            Assert.IsNotNull(getPerson);
        }
    }

    [TestMethod]
    public void FilterByEmailAddress_Success()
    {
        //email to use in filter
        string emailAddress = "fdoughertyi@stanford.edu";

        //filter method to be passed to the Predicate delegate
        bool filterMethod(string name) => name.Contains(emailAddress);

        stringToupleEnumerator = data.FilterByEmailAddress(filterMethod).GetEnumerator();
        (string, string) personInfo;

        while (stringToupleEnumerator.MoveNext())
        {
            personInfo = stringToupleEnumerator.Current;
            Console.WriteLine(personInfo);
            Assert.AreEqual<string>("(Fayette, Dougherty)", personInfo.ToString());
        }
    }

    [TestMethod]
    public void GetAggregateListOfStatesGivenPeopleCollection__GetCorrectData_Success()
    {
        Console.WriteLine(data.GetAggregateListOfStatesGivenPeopleCollection(data.People));
        Assert.IsNotNull(data.GetAggregateListOfStatesGivenPeopleCollection(data.People));
        Assert.IsInstanceOfType(data.GetAggregateListOfStatesGivenPeopleCollection(data.People), typeof(string));
    }
}


