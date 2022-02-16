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
            Assert.IsNotNull(item);
        }
    }
}

