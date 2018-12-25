using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace aspnet_core.Models
{
    public class Person
    {
        public ObjectId Id { get; set; }

        public int PersonId { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("BirthDate")]
        public DateTime BirthDate { get; set; }

    }
}