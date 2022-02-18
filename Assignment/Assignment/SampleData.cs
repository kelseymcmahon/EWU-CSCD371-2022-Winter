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

                //Create the query
                IEnumerable<IPerson> peopleQuery =
                    from line in CsvRows
                    let peopleInfo = line.Split(',')
                    select new Person(peopleInfo[1], 
                                      peopleInfo[2],
                                      new Address(peopleInfo[4], peopleInfo[5], peopleInfo[6], peopleInfo[7]),
                                      peopleInfo[3]);
                    
                List<IPerson> people = peopleQuery.ToList();

                return people;
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
