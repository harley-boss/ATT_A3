// File:        Person.cs
// Assignment:  Assignment 3 - MongoDB
// Programmer:  Harley Boss
// Class:       ATT
// Date:        March 29th 2020
// Description: Class that represents a person (actor/actress) as per the json in the db


using MongoDB.Bson;
using System.Collections.Generic;

namespace A3_MongoDB_hboss {
    class Person {
        public string id { get; set; }
        public List<string> movies { get; set; }
        public string img { get; set; }
        public double popularity { get; set; }

        public Person(BsonDocument person) {
            movies = new List<string>();
            id = person.GetValue("_id").AsString;
            foreach (string s in person.GetValue("movies").AsBsonArray) {
                movies.Add(s);
            }
            img = person.GetValue("img").AsString;
            popularity = person.GetValue("popularity").AsDouble;
        }
    }
}
