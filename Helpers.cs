// File:        Helpers.cs
// Assignment:  Assignment 3 - MongoDB
// Programmer:  Harley Boss
// Class:       ATT
// Date:        March 29th 2020
// Description: Class of helper methods



using A3_MongoDB_hboss.Models;
using System.Collections.Generic;

namespace A3_MongoDB_hboss {
    class Helpers {


        /// <summary>
        /// Creates a list of fullmovies from a list of people and movies
        /// </summary>
        /// <param name="people">List of all actors and actresses as retrieved from db</param>
        /// <param name="movies">List of all movies as retrieved from the db</param>
        /// <returns></returns>
        public static List<FullMovie> CreateFullMovieList(List<Person> people, List<Movie> movies) {
            List<FullMovie> fullMovies = new List<FullMovie>();
            List<string> cast = new List<string>();
            CastDataDictionary castData = new CastDataDictionary();

            // Create a dictionary of cast data
            foreach (Person person in people) {
                foreach (Movie movie in movies) {
                    foreach (string currentMovie in person.movies) {
                        if (currentMovie == movie.id) {
                            castData.Add(movie, person.id);
                            break;
                        }
                    }
                }
            }

            // Create a list of fullmovies
            foreach (KeyValuePair<Movie, List<string>> k in castData) {
                fullMovies.Add(new FullMovie(k.Key, k.Value));
            }
            return fullMovies;
        }
    }
}
