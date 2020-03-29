// File:        Movie.cs
// Assignment:  Assignment 3 - MongoDB
// Programmer:  Harley Boss
// Class:       ATT
// Date:        March 29th 2020
// Description: Class that represents a movie as per json in db



using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3_MongoDB_hboss {
    class Movie {

        public string id { get; set; }
        public string overview { get; set; }
        public List<string> genres { get; set; }
        public string img { get; set; }
        public double popularity { get; set; }

        public Movie(BsonDocument movie) {
            genres = new List<string>();
            id = movie.GetValue("_id").AsString;
            overview = movie.GetValue("overview").AsString;
            foreach (string s in movie.GetValue("genres").AsBsonArray) {
                genres.Add(s);
            }
            img = movie.GetValue("img").AsString;
            popularity = movie.GetValue("popularity").AsDouble;
        }
    }
}
