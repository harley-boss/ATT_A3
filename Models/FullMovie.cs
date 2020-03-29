// File:        FullMovie.cs
// Assignment:  Assignment 3 - MongoDB
// Programmer:  Harley Boss
// Class:       ATT
// Date:        March 29th 2020
// Description: Class that represents a "fullmovie" in the sense that it is all the original movie
//              details plus the cast (array of Person) in that movie.  Is serializable to handle easy
//              writing to db as collection

using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace A3_MongoDB_hboss.Models {
    class FullMovie {
        [BsonId]
        public string _Id { get; set; }

        [BsonElement("overview")]
        public string overview { get; set; }

        public List<string> genres { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.String, AllowTruncation = true)]
        public string img { get; set; }

        [BsonRepresentation(MongoDB.Bson.BsonType.Double, AllowTruncation = true)]
        public double popularity { get; set; }

        public List<string> cast { get; set; }

        public FullMovie(Movie movie, List<string> cast) {
            this._Id = movie.id;
            this.overview = movie.overview;
            this.genres = movie.genres;
            this.img = movie.img;
            this.popularity = movie.popularity;
            this.cast = cast;
        }
    }
}
