using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonRepository.SQL
{
    public class SQLRepository : IPersonRepository
    {
        List<Person> peopleDataSource = new List<Person>
        {
            new Person {FirstName = "Ahmed", LastName = "Mohamed", Rating = 5, StartDate = DateTime.Now},
            new Person {FirstName = "Mahmoud", LastName = "Mohamed", Rating = 4, StartDate = DateTime.Now},
            new Person {FirstName = "Ali", LastName = "Mohamed", Rating = 3, StartDate = DateTime.Now}
        };

        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>();
            foreach (var dataPerson in peopleDataSource)
                people.Add(new Person
                {
                    FirstName = dataPerson.FirstName,
                    LastName = dataPerson.LastName,
                    StartDate = dataPerson.StartDate,
                    Rating = dataPerson.Rating,
                });

            return people;
        }

        public Person GetPerson(string lastName)
        {
            Person person = null;
            var foundPerson = GetDataPerson(lastName);
            if (foundPerson != null) person = GetPersonFromDataPerson(foundPerson);
            return person;
        }

        public void AddPerson(Person newPerson)
        {
            if (GetDataPerson(newPerson.LastName) != null) return;

            var person = new Person()
            {
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName,
                StartDate = newPerson.StartDate,
                Rating = newPerson.Rating,
            };
            peopleDataSource.Add(person);
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            var foundPerson = GetDataPerson(lastName);
            if (foundPerson == null) return;

            foundPerson.FirstName = updatedPerson.FirstName;
            foundPerson.LastName = updatedPerson.LastName;
            foundPerson.StartDate = updatedPerson.StartDate;
            foundPerson.Rating = updatedPerson.Rating;
        }

        public void DeletePerson(string lastName)
        {
            var foundPerson = GetDataPerson(lastName);
            if (foundPerson == null) return;

            peopleDataSource.Remove(foundPerson);
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            throw new NotImplementedException();
        }

        private Person GetDataPerson(string lastName)
        {
            Person foundPerson = null;
            foundPerson = (from p in peopleDataSource where p.LastName == lastName select p).FirstOrDefault();
            return foundPerson;
        }

        private Person GetPersonFromDataPerson(Person dataPerson)
        {
            var person = new Person()
            {
                FirstName = dataPerson.FirstName,
                LastName = dataPerson.LastName,
                StartDate = dataPerson.StartDate,
                Rating = dataPerson.Rating,
            };
            return person;
        }
    }
}