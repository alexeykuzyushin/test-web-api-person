using System;
using PersonsApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace PersonsApi.Services
{
    public class PersonService
    {
        private readonly IMongoCollection<Person> _persons;

        public PersonService(IPersonstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _persons = database.GetCollection<Person>(settings.PersonsCollectionName);
        }

        public List<Person> Get() =>
            _persons.Find(person => true).ToList();

        public Person Get(string id) =>
            _persons.Find<Person>(person => person.Id == id).FirstOrDefault();
        
        public List<Person> Get(int companyId)=>
            _persons.Find(person => person.CompanyId == companyId).ToList();
        
        public Person Create(Person person)
        {
            _persons.InsertOne(person);
            return person;
        }

        public void Update(string id, Person personIn) =>
            _persons.ReplaceOne(person => person.Id == id, personIn);

        public void Remove(string id) => 
            _persons.DeleteOne(person => person.Id == id);
    }
}