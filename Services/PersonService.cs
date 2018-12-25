using System.Collections.Generic;
using System.Linq;
using aspnet_core.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace aspnet_core.Services
{

    public class PersonService
    {

        private readonly IMongoCollection<Person> _persons;

        public PersonService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration["mongo_tests_url"]);
            var database = client.GetDatabase("mongo_tests");
            _persons = database.GetCollection<Person>("Persons");

        }

        public List<Person> Get()
        {
            return _persons.Find( name => true).ToList();
        }

        public Person Get(int personId)
        {
            return _persons.Find( p => p.PersonId == personId).FirstOrDefault();
        }

        public Person Create(Person person)
        {
            _persons.InsertOne(person);
            return person;
        }

        public void Update(Person person, int personId)
        {
            _persons.ReplaceOne(p => p.PersonId == personId, person);
        }

    }

}