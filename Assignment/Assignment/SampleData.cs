using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows
        {
            get { return File.ReadAllLines("People.csv").Skip(1).ToList(); }
        }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            //Create the query
            var stateQuery =
                from line in CsvRows
                let state = line.Split(',')
                orderby state[6]
                select state[6];

            //Execute the query
            var stateList = stateQuery.Distinct().ToList();    

            return stateList;
        }

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
        {
            // retrieve an array of all the state names.
            string[] output = GetUniqueSortedListOfStatesGivenCsvRows().ToArray();

            // combine the array into a single string
            string str = string.Join(", ", output);

            return str;
        }

        // 4.
        public IEnumerable<IPerson> People
        {
            get
            {
                IEnumerable<IPerson> list = new List<IPerson>();

                foreach (string line in CsvRows)
                {
                    string[] personInfo = line.Split(',');

                    string firstName = personInfo[1];
                    string lastName = personInfo[2];
                    string emailAddress = personInfo[3];

                    Address address = new(personInfo[4], personInfo[5], personInfo[6], personInfo[7]);

                    Person person = new(firstName, lastName, address, emailAddress);

                    list.Append(person);
                }
                return list;
            }
        }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();
    }
}
