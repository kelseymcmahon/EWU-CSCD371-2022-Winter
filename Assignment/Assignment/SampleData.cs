using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
        public IEnumerable<string> CsvRows { get => File.ReadAllLines("People.csv").Skip(1).ToList(); }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            //Create the query
            IEnumerable<string> stateQuery =
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
        // Sort the list by State, City, Zip. (Sort the addresses first then select).
        public IEnumerable<IPerson> People
        {
            get
            {
                //Create the query
                IEnumerable<IPerson> peopleQuery =
                    from line in CsvRows
                    let peopleInfo = line.Split(',')
                    orderby peopleInfo[5], peopleInfo[6], peopleInfo[7]
                    select new Person(peopleInfo[1], 
                                      peopleInfo[2],
                                      new Address(peopleInfo[5], peopleInfo[4], peopleInfo[6], peopleInfo[7]),
                                      peopleInfo[3]);
                
                //Execute the query
                List<IPerson> people = peopleQuery.ToList();

                return people;
            }
        }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter)
        {
            //Create the query
            IEnumerable<(string, string)> emailFilterQuery =
                from personInfo in People
                where filter(personInfo.EmailAddress)
                select (personInfo.FirstName, personInfo.LastName);

            //Execute the query
            IEnumerable<(string, string)> list = emailFilterQuery.ToList();

            return list;
        }

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people)
        {
            //Create the query
            IEnumerable<string>? personFilterQuery =
                from personInfo in People
                select personInfo.Address.State;

            IEnumerable<string> personlist = personFilterQuery.Distinct().ToArray();

            string personStringList = personlist.Aggregate((s1, s2) => s1 + ", " + s2);

            return personStringList;
        }
    }
}
